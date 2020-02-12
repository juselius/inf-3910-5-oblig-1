module Oblig1.Plain

// note the return type of 'a for failwith. failwith "returns" whatever type is
// required to satisfy the type checker, but at runtime it throws an exception
let private notImplemented () = failwith "not implemented"

type private NotImplemented = unit

type Attr = NotImplemented

type Element =
  | Elt of Elem
  | Text of string
and Elem = NotImplemented

let elt name (attrs : Attr list) (elt : Element list) : Element =
    notImplemented ()

let attr name value : Attr = notImplemented ()

let text str : Element = notImplemented ()

// Use elt and attr to implement the combinators (tags) for the DSL
// Note that class is a reserved word, and id is a standard function
// so we need to name them differently. Either use a "name escape" with
// double back ticks like ``class`` (you can even have spaces in names, eg.
// let ``my funny func`` x = ...) or prefix with an underscore

let toXml (el : Element) : string = notImplemented ()

let toJson (el : Element) : string = notImplemented ()

let test () =
    let doc =
        html [ _class "1"; _id "2" ] [
            head [] [
                meta [ charset "utf-8" ] []
            ]
            body [ _id "foo" ] []
        ]
    printfn "%s" <| toXml doc