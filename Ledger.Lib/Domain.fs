namespace Ledger.Lib

open UtilityString


module Domain =

    type AccountName = private AccountName of string

    module AccountName =

        [<Literal>]
        let MinLength = 1


        [<Literal>]
        let MaxLength = 80


        // Smart constructor
        let create inputStr =
            match inputStr with
            | ContainsNewLine -> Error (sprintf "Account names may not contain newline characters")
            | StringLengthIsIllegal MinLength MaxLength -> Error (sprintf "Account name must be %d to %d characters." 1 80)
            | _ -> Ok (AccountName inputStr)


        // Unwraps inner value.
        let value (AccountName innerData) = innerData

