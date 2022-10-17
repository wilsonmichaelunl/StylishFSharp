type BillingDetails =
    { Name: string
      Billing: string
      Delivery: string option }
    
let myOrder =
    { Name = "Kit Eason"
      Billing = "112 Fibonacci Street"
      Delivery = None }