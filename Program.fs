module NotTopLevel =
    let errorFn () =
        task {
            // let values = [1;2;3;4]
            // for (value) in values do // no warning
            //     printfn $"{value}"
            
            let values = [|1,'a'; 2,'b'; 3,'c'; 4,'d'|]
            for (value, letter) in values do // warning here
                printfn $"{value}:{letter}"
            // for pair in values do // Also provides a warning
            //     printfn $"{fst pair}:{snd pair}"
        }
    
printfn "Hello from F#"