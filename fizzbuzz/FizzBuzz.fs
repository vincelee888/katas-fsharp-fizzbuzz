namespace fizzbuzz.Tests

open NUnit.Framework
open FsUnit

type FizzBuzz() =
   member x.Output input = input.ToString()
   
[<TestFixture>] 
type ``Given a FizzBuzz`` ()=
   let fb = new FizzBuzz()

   [<Test>] 
   member test. ``1 begets "1".`` ()=
    fb.Output 1 |> should equal "1"

   [<Test>] 
   member test. ``2 begets "2".`` ()=
    fb.Output 2 |> should equal "2"