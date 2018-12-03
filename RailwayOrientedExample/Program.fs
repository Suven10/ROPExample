// Learn more about F# at http://fsharp.org

open System
open DomainTypes
//open Validation
open UseCases

let castAs<'T when 'T : null> (o:obj) = 
  match o with
  | :? 'T as res -> res
  | _ -> null

[<EntryPoint>]
let main argv =
    let input3 = {name="Alice"; email="Good@gmail.com"}
    handleUpdateRequest input3 
    |> printfn "Result3=%A"
   
    Console.Read() |>ignore
    0 // return an integer exit code
