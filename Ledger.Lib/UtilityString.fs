namespace Ledger.Lib


module UtilityString =


    let (|ContainsNewLine|_|) (str: string)  =
        if str.Contains(System.Environment.NewLine) then Some ()
        else None


    let (|StringLengthIsIllegal|_|) (minLength: int) (maxLength: int) (str: string)  =
        if str.Length < minLength then
            None
        elif str.Length > maxLength then
            None
        else
            Some ()

