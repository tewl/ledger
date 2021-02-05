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
        | ContainsNewLine _ -> passTest ()
        | _ -> failTest ()


    [<Fact>]
    let ``when given a string with no newlines returns None`` () =
        let str = "foo"
        match str with
        | ContainsNewLine -> failTest ()
        | _ -> passTest ()
