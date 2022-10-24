type Student = { Name: string; Grade: char }

[ { Name = "Jones"; Grade = 'A' }
  { Name = "Garcia"; Grade = 'B' }
  { Name = "Ng"; Grade = 'A' } ]
|> List.tryFind (fun x -> x.Grade = 'B')

let rms s =
    s
    |> Seq.averageBy (fun item -> item ** 2.)
    |> sqrt

let product s =
    s
    |> Seq.fold (fun acc elem -> acc * elem) 1.

[|2.0;3.0|] |> product