let caseSwitch = 2

match caseSwitch with
| 1 -> printfn "Case 1"
| 2 | 3 as x -> printfn "Maybe 2, Maybe 3, but actually %i" x
|_ -> printfn "Default case"

let describe stringList =
    match stringList with
    | [] -> "An empty pond"
    | head::tail ->
        sprintf "A pond containing one fish: %s and (%i more fish)" head (tail |> List.length)

["One fish"] |> describe