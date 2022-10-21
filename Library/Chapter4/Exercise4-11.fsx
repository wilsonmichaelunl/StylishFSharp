#load "ExerciseSetup.fs"

open ExerciseSetup

House.getRandom 20
|> Array.filter (fun x -> x.Price < 100_000m)
|> Array.tryPick (fun x ->
    match Distance.tryToSchool x with
    | Some dist -> Some(x, dist)
    | None -> None)