namespace Ledger.Test


open System
open Xunit
open Swensen.Unquote
open Ledger.Lib.UtilityString
open TestUtil


module ContainsNewLine =


    [<Fact>]
    let ``when given a string containing a newline returns Some`` () =
        let str = "one" + System.Environment.NewLine + "two"
        match str with
        | ContainsNewLine -> passTest ()
        | _ -> failTest ()


    [<Fact>]
    let ``when given a string with no newlines returns None`` () =
        let str = "foo"
        match str with
        | ContainsNewLine -> failTest ()
        | _ -> passTest ()


module StringLengthIsIllegal =

    [<Fact>]
    let ``when string is too short returns None`` () =
        let str = "foo"
        match str with
        | StringLengthIsIllegal 5 10 -> passTest ()
        | _ -> failTest ()


    [<Fact>]
    let ``when string is too long returns None`` () =
        let str = "12345678901"
        match str with
        | StringLengthIsIllegal 5 10 -> passTest ()
        | _ -> failTest ()


    [<Fact>]
    let ``when string is min size returns Some`` () =
        let str = "12345"
        match str with
        | StringLengthIsIllegal 5 10 -> failTest ()
        | _ -> passTest ()


    [<Fact>]
    let ``when string is max size returns Some`` () =
        let str = "1234567890"
        match str with
        | StringLengthIsIllegal 5 10 -> failTest ()
        | _ -> passTest ()
