#load "ExerciseSetup.fs"

open ExerciseSetup

module Array =
    let inline tryAverageBy price (values : 'T[]) =
        if values.Length = 0 then
            None
        else
            values |> Array.averageBy price |> Some


House.getRandom 20
|> Array.filter (fun x -> x.Price > 600_000m)
|> Array.tryAverageBy (fun x -> x.Price)



