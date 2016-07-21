module reader

    open System.Text.RegularExpressions

    let tokenize (codeString : string) =
        let malRegex = new Regex("[\s,]*(~@|[\[\]{}()'`~^@]|\"(?:\\\\.|[^\\\\\"])*\"|;.*|[^\s\[\]{}('\"`,;)]*)")
        let matches = malRegex.Matches(codeString)
        seq {
            for m in matches do
            yield m.Groups.[1].Value
        } 
        |> Seq.toList

    let readAtom (token : string) =
        

    let readList (tokenList : string list) =
        

    let readForm (tokenList : string list) =
        tokenList
        |> List.mapi (fun i t -> match t with
                                 | "(" -> List.map readList (Seq.skip i tokenList)
                                 | _ -> readAtom t

    let readStr codeString =
        codeString
        |> tokenize
        |> readForm