namespace CatTheFoProg

open System.Threading
open CatTheFoProg.Solutions

module Main =
    [<EntryPoint>]
    let main argv =
        let longAwaitedInc x =
            Thread.Sleep(1000)
            x + 1
        
        let memoizedInc = TypesAndFunctions.memoize longAwaitedInc
        
        printfn "first"
        memoizedInc 3 |> ignore
        
        printfn "second"
        memoizedInc 3 |> ignore
        
        printfn "third"
        memoizedInc 3 |> ignore
        0
