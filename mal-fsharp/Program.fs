open System

let read (input : string) =
    input

let eval (readValue : string) =
    readValue

let print (evalValue : string) =
    match evalValue with
    | "exit" -> printfn "Goodbye."
                evalValue
    | _ -> printfn "%s" evalValue
           evalValue

let rep (input: string) =
    read input |> eval |> print

let rec loop () =
    printf "user> "
    match rep (Console.ReadLine()) with
    | "exit" -> 0
    | _ -> loop ()

[<EntryPoint>]
let main argv : int = 
    loop ()