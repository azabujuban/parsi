module HorizontalRulesTests

open FsUnit
open NUnit.Framework
open HorizontalRules
open TestHelpers

[<Test>]
let ``ident parser parses 0 idents``() =
    Parsing "slkdfslkj" Using zeroToThreeSpacesOfIdent Succeeds
    Parsing "" Using zeroToThreeSpacesOfIdent Succeeds

[<Test>]
let ``ident parser parses 1 idents``() =
    Parsing "slkdfslkj" Using zeroToThreeSpacesOfIdent Succeeds
    Parsing "" Using zeroToThreeSpacesOfIdent Succeeds

[<Test>]
let ``ident parser parses 2 idents``() =
    Parsing "slkdfslkj" Using zeroToThreeSpacesOfIdent Succeeds
    Parsing "" Using zeroToThreeSpacesOfIdent Succeeds

[<Test>]
let ``ident parser parses 3 idents``() =
    Parsing "slkdfslkj" Using zeroToThreeSpacesOfIdent Succeeds
    Parsing "" Using zeroToThreeSpacesOfIdent Succeeds
    
[<Test>]
let ``ident parser doesnt parse 4 idents``() =
    Parsing "    slkdfslkj" Using zeroToThreeSpacesOfIdent Fails
    Parsing "    " Using zeroToThreeSpacesOfIdent Fails
    
    
    