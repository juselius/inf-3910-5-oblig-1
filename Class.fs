module Oblig1.Class

let private notImplemented () = failwith "not implemented"

type Markup() =
    abstract ToXml : unit -> string
    default this.ToXml () = ""

type Element() =
    inherit Markup()
    override this.ToXml () = ""

type Attr() =
    inherit Markup()
    override this.ToXml () = ""

let elt name (attrs : Attr list) (elt : Element list) = notImplemented ()

let attr name value = notImplemented ()

let text str = notImplemented ()

let test () =
    let doc =
        html [ _class "1"; _id "2" ] [
            head [] [
                meta [ charset "utf-8" ] []
            ]
            body [ _id "foo" ] []
        ] :> Markup
    printfn "%s" <| doc.ToXml ()
