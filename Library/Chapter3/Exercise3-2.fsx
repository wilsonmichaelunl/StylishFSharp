type BillingDetails =
    { Name: string
      Billing: string
      Delivery: string option }
    
let myOrder =
    { Name = "Kit Eason"
      Billing = "112 Fibonacci Street"
      Delivery = None }
    
let hisOrder =
    { Name = "John Doe"
      Billing = "314 Pi Avenue"
      Delivery = None }
    
let herOrder =
    { Name = "Jane Smith"
      Billing = null
      Delivery = None }
    
let orders = [| myOrder; hisOrder; herOrder |]

let countBillingAddress billingDetails =
    billingDetails
    |> Array.choose (fun x ->
                        match x.Billing with
                        | null -> None
                        | _ -> x.Billing |> Some)
    |> Array.length