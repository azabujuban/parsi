module HorizontalRules
open FParsec

let zeroToThreeSpacesOfIdent : Parser<unit, unit> =
    skipManyMinMaxSatisfy 0 3 (isAnyOf [' '])
