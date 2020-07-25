namespace CatTheFoProg.Solutions

module EssenceOfComposition = 
    let id x = x
    let compose f g x = f (g x)
