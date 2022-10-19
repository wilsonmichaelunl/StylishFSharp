#load "ExerciseSetup.fs"

open ExerciseSetup

House.getRandom 20
|> Array.choose (fun x ->
            match x |> Distance.tryToSchool with
            | Some dist -> Some(x, dist)
            | None -> None)
|> Array.head

