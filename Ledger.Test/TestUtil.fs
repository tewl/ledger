namespace Ledger.Test


open Swensen.Unquote


module TestUtil =

    let passTest () =
        test <@ true @>


    let failTest () =
        test <@ false @>
