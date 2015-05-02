namespace fizzbuzz.Tests

open NUnit.Framework
open FsUnit

type FizzBuzz() =
    member x.Output input = 
        match input with
        | 5 -> "Buzz"
        | input when input % 3 = 0 -> "Fizz"
        | _ -> input.ToString()
   
[<TestFixture>] 
type ``Given a FizzBuzz`` ()=
    let fb = new FizzBuzz()

    [<Test>] 
    member test. ``1 begets "1".`` ()=
        fb.Output 1 |> should equal "1"

    [<Test>] 
    member test. ``2 begets "2".`` ()=
        fb.Output 2 |> should equal "2"

    [<Test>]
    member test. ``3 begets "Fizz".`` ()=
        fb.Output 3 |> should equal "Fizz"

    [<Test>]
    member test. ``5 begets "Buzz".`` ()=
        fb.Output 5 |> should equal "Buzz"

    [<Test>]
    member test. ``6 begets "Fizz".`` ()=
        fb.Output 6 |> should equal "Fizz"