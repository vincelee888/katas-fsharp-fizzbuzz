namespace fizzbuzz.Tests

open NUnit.Framework
open FsUnit

type FizzBuzz() =
    member x.Output input = 
        match input with
        | input when input % 5 = 0 && input % 3 = 0 -> "FizzBuzz"
        | input when input % 3 = 0 -> "Fizz"
        | input when input % 5 = 0 -> "Buzz"
        | _ -> input.ToString()
   
[<TestFixture>] 
type ``Given a FizzBuzz`` ()=
    let fb = new FizzBuzz()

    [<TestCase(1, "1")>] 
    [<TestCase(2, "2")>] 
    [<TestCase(3, "Fizz")>] 
    [<TestCase(5, "Buzz")>] 
    [<TestCase(6, "Fizz")>] 
    [<TestCase(10, "Buzz")>] 
    [<TestCase(15, "FizzBuzz")>] 
    member test. ``input begets output.`` (input, output)=
        fb.Output input |> should equal output