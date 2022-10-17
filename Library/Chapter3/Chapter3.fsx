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