let values = [1;2;3]

let a =
    task {
        for value in values do
            printfn $"{value}"
    }

let v =
    task {
        for value in [1;2;3] do
            printfn $"{value}"
    }

printfn "Hello from F#"
