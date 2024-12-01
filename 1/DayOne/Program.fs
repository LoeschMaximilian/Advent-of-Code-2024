// For more information see https://aka.ms/fsharp-console-apps
open System

let read =
    Seq.initInfinite (fun _ -> Console.ReadLine())
    |> Seq.takeWhile (fun x -> not (x = null))

[<EntryPoint>]
let main argv =
    let (left, right) =
        read
        |> Seq.map (fun x -> x.Split "   " |> Seq.map (int))
        |> Seq.fold (fun state element -> (Seq.head element :: fst state, Seq.last element :: snd state)) ([], [])

    (0, List.sort left, List.sort right)
    |||> Seq.fold2 (fun acc a b -> acc + abs (a - b))
    |> printfn "%A"

    0
