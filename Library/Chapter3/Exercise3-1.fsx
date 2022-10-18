
type Delivery =
    | AsBilling
    | Physical of string
    | Download
    | ClickAndCollect of int

type BillingDetails = {
    Name : string
    Billing : string
    Delivery : Delivery }

let tryDeliveryLabel (billingDetails : BillingDetails) =
    match billingDetails.Delivery with
    | AsBilling ->
        billingDetails.Billing |> Some
    | Physical address ->
        address |> Some
    | Download ->
        None
    | ClickAndCollect id -> None
    |> Option.map (fun address ->
        sprintf "%s\n%s" billingDetails.Name address)

let deliveryLabels (billingDetails : BillingDetails seq) =
    billingDetails
    |> Seq.choose  tryDeliveryLabel

let myOrder = {
    Name = "Kit Eason"
    Billing = "112 Fibonacci Street\nErehwon\n35813"
    Delivery = AsBilling }

let hisOrder = {
    Name = "John Doe"
    Billing = "314 Pi Avenue\nErewhon\n15926"
    Delivery = Physical "16 Planck Parkway\nErewhon\n62291" }

let herOrder = {
    Name = "Jane Smith"
    Billing = "9 Gravity Road\nErewhon\n80665"
    Delivery = Download }

let clarkOrder =
    { Name = "Clark Baby"
      Billing = "101 Cute Lane"
      Delivery = ClickAndCollect 1 }
// seq
//     [ "Kit Eason
//        112 Fibonacci Street
//        Erehwon
//        35813";
//       "John Doe
//        16 Planck Parkway
//        Erewhon
//        62291"]
let orders = [ myOrder; hisOrder; herOrder; clarkOrder ]
orders |> deliveryLabels

let collectionsFor storeId billingDetails =
    billingDetails
    |> List.choose (fun x ->
                        match x.Delivery with
                        | ClickAndCollect id when id = storeId -> Some x
                        | _ -> None)