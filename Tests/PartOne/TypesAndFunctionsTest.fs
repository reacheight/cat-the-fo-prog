namespace CatTheFoProg.Tests.PartOne

open CatTheFoProg.Solutions
open NUnit.Framework
open FsCheck
open FsCheck.NUnit

[<TestFixture>]
type TypesAndFunctionsTest() =

    [<Test>]
    member _.``memoize produces the same result as given functions``() =
        let inc x = x + 1
        let memoizeInc = TypesAndFunctions.memoize inc
        
        let memoizeProducesSameResult x =
            inc x = memoizeInc x
        
        Check.QuickThrowOnFailure memoizeProducesSameResult
