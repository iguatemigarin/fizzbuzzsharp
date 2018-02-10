[<EntryPoint>]
let main argv =
    let range = [1..100]
    FizzBuzz.printFizzBuzzRange range
    System.Console.ReadKey true |> ignore
    0
