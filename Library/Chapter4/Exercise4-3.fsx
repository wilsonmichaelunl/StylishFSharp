#load "ExerciseSetup.fs"

open ExerciseSetup

ExerciseSetup.House.getRandom 20
|> Array.filter (fun x -> x.Price > 250_000m)
