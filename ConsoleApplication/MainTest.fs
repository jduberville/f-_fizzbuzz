module MainTest

open FsUnit
open Main
open NUnit.Framework

[<TestFixture>]
type ``FizzBuzz kata``() = 
    
    [<Test>]
    member x.``should return Fizz if input is multiple of 3``() = Main.fizzbuzz [ 6 ] |> should equal [ "Fizz" ]
    
    [<Test>]
    member x.``should return FizzBazz if input is multiple of 3 and 7``() = 
        Main.fizzbuzz [ 21 ] |> should equal [ "FizzBazz" ]
    
    [<Test>]
    member x.``should return Buzz if input is multiple of 5``() = Main.fizzbuzz [ 25 ] |> should equal [ "Buzz" ]
    
    [<Test>]
    member x.``should return FizzBuzz if input is multiple of 3 and 5``() = 
        Main.fizzbuzz [ 15 ] |> should equal [ "FizzBuzz" ]
    
    [<Test>]
    member x.``should return BuzzBazz if input is multiple of 5 and 7``() = 
        Main.fizzbuzz [ 35 ] |> should equal [ "BuzzBazz" ]
