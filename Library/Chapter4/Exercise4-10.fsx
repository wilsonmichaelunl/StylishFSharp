#load "ExerciseSetup.fs"

open ExerciseSetup

let inline tryAverage (values : 'T[]) =
    if values.Length = 0 then
        None
    else
        values |> Array.average |> Some


House.getRandom 20
|> Array.filter (fun x -> x.Price > 400_000m)
|> Array.map (fun x -> x.Price)
|> tryAverage
|> fun x ->
    match x with
    | Some avg -> avg
    | None -> 0


