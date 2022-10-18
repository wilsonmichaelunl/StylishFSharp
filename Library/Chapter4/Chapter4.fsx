// Listing 4-1
type House = { Address: string; Price: decimal }

let houses =
    [|
        { Address = "1 Acacia Avenue"; Price = 250_000m }
        { Address = "2 Bradley Stree"; Price = 380_000m }
        { Address = "1 Carlton Road"; Price = 90_000m }
    |]

let cheapHouses =
    houses |> Array.filter (fun h -> h.Price < 100_000m)