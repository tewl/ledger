namespace Ledger.Lib


module UtilityString =


    let (|ContainsNewLine|_|) (str: string)  =
        if str.Contains(System.Environment.NewLine) then Some ()
        else None


    let (|StringLengthIsIllegal|_|) (minLength: int) (maxLength: int) (str: string)  =
        if str.Length < minLength then
            Some ()
        elif str.Length > maxLength then
            Some ()
        else
            None

