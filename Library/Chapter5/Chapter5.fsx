type Student = { Name: string; Grade: char }

[ { Name = "Jones"; Grade = 'A' }
  { Name = "Garcia"; Grade = 'B' }
  { Name = "Ng"; Grade = 'A' } ]
|> List.tryFind (fun x -> x.Grade = 'B')