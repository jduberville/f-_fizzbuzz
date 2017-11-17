module Program

open Main

[<EntryPoint>]
let main argv = 
    printfn "%A" (Main.fizzbuzz [ 1..100 ])
    1
