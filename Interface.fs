module Oblig1.Interface

let private notImplemented () = failwith "not implemented"

type private NotImplemented = unit

type IMarkup =
    abstract ToXml : unit -> string

type IElt =
    inherit IMarkup

type IAttr =
    inherit IMarkup

type Attr = NotImplemented

type Element = NotImplemented

let elt name (attrs : IAttr list) (elt : IElt list) = notImplemented ()

let attr name value = notImplemented ()

let text str = notImplemented ()

let test () =
    let doc =
        html [ _class "1"; _id "2" ] [
            head [] [
                meta [ charset "utf-8" ] []
            ]
            body [ _id "foo" ] []
        ] :> IMarkup
    printfn "%s" <| doc.ToXml ()
