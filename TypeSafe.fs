// In this exercise you should try to make the "meta" tag type safe
// so that you cannot pass in invalid tags
// this is a non-trivial exercise, and probably requires a bit of thinking
// and googling. consider it a bonus exercise.
module Oblig1.TypeSafe

let private notImplemented () = failwith "not implemented"

type private NotImplemented = unit

type IMarkup =
    abstract ToXml : unit -> string

type IElt =
    inherit IMarkup

type IAttr =
    inherit IMarkup

// Hint: 'A in Attr is not used, it's a _phantom type_,
// it only exists to make each Attr<_> distinct!
type Attr<'A when 'A :> IAttr> = NotImplemented

// Here 'A is not phantom, and should be used to prevent mixing IElt and IAttrs
type Element<'A when 'A :> IElt> = NotImplemented

let elt name (attrs : 'A list when 'A :> IAttr) (elt : IElt list) = notImplemented ()

let attr name value = notImplemented ()

let text str = notImplemented ()

module Meta =
    type private IMeta = inherit IAttr
    type private Meta = Attr<IMeta>
    let charset : string -> Meta = notImplemented ()
    let name : string -> Meta = notImplemented ()
    let meta :  Meta list -> IElt list -> IElt = notImplemented ()

let _class : string -> Attr<IAttr> = notImplemented ()

let _id : string -> Attr<IAttr> = notImplemented ()

let html : Attr<IAttr> list -> IElt list -> IElt = notImplemented ()

let body : Attr<IAttr> list -> IElt list -> IElt  = notImplemented ()

let head : Attr<IAttr> list -> IElt list -> IElt = notImplemented ()

let test () =
    let doc =
        html [ _class "1"; _id "2" ] [
            head [] [
                Meta.meta [ Meta.charset "utf-8" ] []
            ]
            body [ _id "foo" ] []
        ] :> IMarkup
    printfn "%s" <| doc.ToXml ()
