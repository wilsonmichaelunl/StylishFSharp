#load "ExerciseSetup.fs"

open ExerciseSetup

ExerciseSetup.House.getRandom 20
|> Array.averageBy(fun x -> x.Price)
