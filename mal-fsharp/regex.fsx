open System
open System.Text.RegularExpressions

let malRegex = new Regex("[\s,]*(~@|[\[\]{}()'`~^@]|\"(?:\\\\.|[^\\\\\"])*\"|;.*|[^\s\[\]{}('\"`,;)]*)")

let matches = malRegex.Matches("(QUICK (WRITE (A PROGRAM) IN (YOUR FAVORITE LANGUAGE) THAT (FINDS THE INNERMOST (WORD OR EXPRESSION) OF (THIS POST)) (UNDER A (RANDOM CHARACTER POSITION)))(OR (THIS BIRD) IS GONNA (STAB YOU)))")

let matchesToList (matches: MatchCollection) =
        seq {
            for m in matches do
                yield m.Groups.[1].Value
        } |> Seq.toList

let matchesText = matchesToList matches

matchesText |> List.iter (fun m -> printfn "%s" m)