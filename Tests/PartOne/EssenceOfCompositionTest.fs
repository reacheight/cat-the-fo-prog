namespace CatTheFoProg.Tests.PartOne

open CatTheFoProg.Solutions
open NUnit.Framework
open FsCheck
open FsCheck.NUnit

[<TestFixture>]
type EssenceOfCompositionTest() =

    [<Test>]
    member _.``composition respects id``() =
        let lengthComposeId = EssenceOfComposition.compose String.length EssenceOfComposition.id
        let compositionRespectsId s =
            lengthComposeId s = String.length s
        
        Check.QuickThrowOnFailure compositionRespectsId

    [<Property>]
    member _.``id is correct`` (x : int) =
         EssenceOfComposition.id x = id x
    
    [<Property>]
    member _.``compose is correct`` (f : string -> int) (g : int -> string) (x : int) =
        EssenceOfComposition.compose f g x = (f << g) x
