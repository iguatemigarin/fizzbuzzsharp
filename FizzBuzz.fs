module FizzBuzz

type FizzBuzzNumber =
    | Fizz of int
    | Buzz of int
    | FizzBuzz of int
    | Number of int

let isDivisible dividend divisor = dividend % divisor = 0
let isFizz num = isDivisible num 3
let isBuzz num = isDivisible num 5

let makeFizzBuzz num =
    match (isFizz num, isBuzz num) with
    | (true, true) -> FizzBuzz num
    | (true, false) -> Fizz num
    | (false, true) -> Buzz num
    | _ -> Number num

let printFizzBuzz fizzBuzzOption =
    match fizzBuzzOption with
    | Fizz _ -> printfn "Fizz"
    | Buzz _ -> printfn "Buzz"
    | FizzBuzz _ -> printfn "FizzBuzz"
    | Number x -> printfn "%i" x

let printFizzBuzzRange = List.map makeFizzBuzz >> List.map printFizzBuzz >> ignore
