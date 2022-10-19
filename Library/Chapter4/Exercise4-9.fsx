#load "ExerciseSetup.fs"

open ExerciseSetup

House.getRandom 20
|> Array.groupBy (fun x -> x.Price |> PriceBand.fromPrice)
|> Array.map (fun (x,y) ->
    x,y |> Array.sortBy (fun houseList  -> houseList.Price))