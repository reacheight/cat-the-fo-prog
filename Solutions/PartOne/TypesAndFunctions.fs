namespace CatTheFoProg.Solutions

open System.Collections.Generic

module TypesAndFunctions =
    let memoize (f : 'a -> 'b) =
        let map = Dictionary()
        let lazyF x =
            if map.ContainsKey(x) then map.[x] else

            let value = f x
            map.Add(x, value)
            value

        lazyF
