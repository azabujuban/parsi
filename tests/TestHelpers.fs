module TestHelpers
open NUnit.Framework
open FParsec

type dsl = Using
type expectation = Succeeds | Fails

exception private ParserFailedException of string
exception private ParserSucceededException

let Parsing line stub parser expected =
    match (expected, run parser line) with
    |(Succeeds, Success(_, _, _)) -> ()
    |(Succeeds, Failure(err, _, _)) -> raise (ParserFailedException err)
    |(Fails, Success(_, _, _)) -> raise ParserSucceededException
    |(Fails, Failure(_, _, _)) -> ()

    