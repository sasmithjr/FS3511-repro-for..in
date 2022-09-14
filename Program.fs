module NotTopLevel =
    let errorFn () =
        task {
            // let values = [1;2;3;4]
            // for (value) in values do
            //     printfn $"{value}"
            let values = [1,'a'; 2,'b'; 3,'c'; 4,'d']
            for (value, letter) in values do
                printfn $"{value}:{letter}"
        }
    
printfn "Hello from F#"