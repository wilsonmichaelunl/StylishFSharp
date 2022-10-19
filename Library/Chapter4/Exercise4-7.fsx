#load "ExerciseSetup.fs"

open ExerciseSetup

House.getRandom 20
|> Array.filter (fun x -> x.Price > 200_000m)
|> Array.averageBy (fun x -> x.Price)
