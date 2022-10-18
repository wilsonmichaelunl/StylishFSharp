#load "ExerciseSetup.fs"

open ExerciseSetup

ExerciseSetup.House.getRandom 20
|> Array.map (fun x ->
    sprintf "Address: %s - Price: %M" x.Address x.Price)