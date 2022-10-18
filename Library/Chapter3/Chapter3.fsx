open System

type SafeString (s : string ) =
    do
        if s = null then
            raise <| System.ArgumentException()
    member _.Value = s
    override _.ToString() = s
    
type BillingDetails = {
    name: SafeString
    billing: SafeString
    delivery: SafeString option
}

let printDeliveryAddress details =
    details.delivery
    |> Option.map (fun address -> address.Value.ToUpper())
    |> Option.iter (fun address ->
                        printfn "Delivery Address:\n%s\n%s"
                            (details.name.Value.ToUpper()) address)

let myApiFunction stringParam =
    let s =
        stringParam
        |> Option.ofObj
        |> Option.defaultValue "(none)"
    printfn "%s" (s.ToUpper())

// HELLO
myApiFunction "hello"
// (NONE)
myApiFunction null


let showHeartRate (rate : Nullable<int>) =
    rate
    |> Option.ofNullable
    |> Option.map (fun r -> r.ToString())
    |> Option.defaultValue "N/A"

// 96
showHeartRate (System.Nullable(96))
// N/A
showHeartRate (System.Nullable())


let random = new Random()

let tryLocationDescription locationId =
    let r = random.Next(1, 100)
    if r < 50 then
        Some (sprintf "Location number %i" r)
    else
        None

let tryLocationDescriptionNullable locationId =
    tryLocationDescription()
    |> Option.toObj

// Sometimes null, sometimes "Location number #"
tryLocationDescriptionNullable 99


let tryLocationDescriptionByRef (locationId: int, description : string byref) =
    let r = random.Next(1, 100)
    if r < 50 then
        description <- sprintf "Location number %i" r
        true
    else
        description <- null
        false

let getHeartRateInternal() =
    let rate = random.Next(0, 200)
    if rate = 0 then
        None
    else
        Some rate

let tryGetHeartRate() =
    getHeartRateInternal()
    |> Option.toNullable