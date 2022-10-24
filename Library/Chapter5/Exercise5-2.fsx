let extremes s =
    s |> Seq.max,
    s |> Seq.min

[| 1.0; 2.3; 11.1; -5. |] |> extremes
