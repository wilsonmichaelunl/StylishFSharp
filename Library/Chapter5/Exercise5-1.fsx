let clip ceiling s =
    s
    |> Seq.map (fun x -> min x ceiling)

[| 1.0; 2.3; 11.1 |] |> clip 10.0


