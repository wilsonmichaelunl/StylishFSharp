#load "ExerciseSetup.fs"

open ExerciseSetup

House.getRandom 20
|> Array.filter (fun x -> x.Price > 200_000m)
|> Array.iter (fun x -> printfn "%s Price: %M" x.Address x.Price)
