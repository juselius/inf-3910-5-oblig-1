module Oblig1.Main

open Oblig1

// in this oblig you will (probably) need to loop over lists
// here are some examples of looping which you can play around with until
// you understand how they work

let a = List.map (fun x -> x + 1) [1..3]
let b = List.fold (fun acc x -> acc + x) 0 [1..3]
let c = List.fold (fun acc x -> (x + 1) :: acc) [] [1..3]
let d = List.fold (fun acc x -> Set.add (x + 1) acc) Set.empty [1..3]

[<EntryPoint>]
let main argv =
    Plain.test ()
    Interface.test ()
    Class.test ()
    TypeSafe.test ()
    0 // return an integer exit code
