// For more information see https://aka.ms/fsharp-console-apps
open System

let read = Seq.initInfinite( fun _ -> Console.ReadLine()) 
        |> Seq.takeWhile(fun x -> not (x = null))

[<EntryPoint>]
let main argv  =
        let list = read
        for s in list do
                printf "%s\n" s
        0
