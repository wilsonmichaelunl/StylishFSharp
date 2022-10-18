module ExerciseSetup

type House = { Address: string; Price: decimal }

module House =
    let private random = System.Random(Seed = 1)

    let getRandom count =
        Array.init count (fun i ->
            { Address = sprintf "%i Stochastic Street" (i+1)
              Price = random.Next(50_000, 500_000) |> decimal })

module Distance =
    let private random = System.Random(Seed = 1)

    let tryToSchool house =
        let dist = random.Next(10) |> double
        if dist < 5. then
            Some dist
        else
            None

type PriceBand = | Cheap | Medium | Expensive

module PriceBand =
    let fromPrice price =
        if price < 100_000m then
            Cheap
        elif price < 200_000m then
            Medium
        else
            Expensive