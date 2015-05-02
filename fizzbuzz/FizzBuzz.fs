namespace fizzbuzz.Tests

open NUnit.Framework
open FsUnit

type FizzBuzz() =
   member x.Output input = "1"
   
[<TestFixture>] 
type ``Given a FizzBuzz`` ()=
   let fb = new FizzBuzz()

   [<Test>] 
   member test. ``1 begets "1".`` ()=
    fb.Output 1 |> should equal "1"