module Main

let mapOfMultiplesAndWords = 
    [ (3, "Fizz")
      (5, "Buzz")
      (7, "Bazz") ]

let returnValueIfKeyIsMultipleOf number = 
    List.map (function 
        | (key, value) when (number) % key = 0 -> value
        | _ -> "")

let wordsForMultiples number = mapOfMultiplesAndWords |> returnValueIfKeyIsMultipleOf number
let concatAllWordsInOne = List.fold (fun (acc : string) (c : string) -> acc + c) ""
let wordFor = wordsForMultiples >> concatAllWordsInOne

let word number = 
    match (wordFor number) with
    | "" -> string number
    | _ -> wordFor number

let fizzbuzz list = list |> List.map word 
