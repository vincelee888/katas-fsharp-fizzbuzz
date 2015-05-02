namespace fizzbuzz

type FizzBuzz() =
    member x.Output input = 
        match input with
        | input when input % 5 = 0 && input % 3 = 0 -> "FizzBuzz"
        | input when input % 3 = 0 -> "Fizz"
        | input when input % 5 = 0 -> "Buzz"
        | _ -> input.ToString()
