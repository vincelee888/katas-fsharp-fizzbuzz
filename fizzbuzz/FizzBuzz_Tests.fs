namespace fizzbuzz

open NUnit.Framework
open FsUnit
   
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