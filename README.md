# Oblig 1

In this exercise you will create an Embedded Domain Specific Language (EDSL) for
a small subset of HTML:

```html
<html>
  <head>
    <meta charset="utf-8" name="edsl" />
  <head>
  <body class="pretty">
    <h1>I heart F#</h1>
  </body>
</html>
```

so that the same structure can be represented as:

```fsharp
html [] [
  head [] [
    meta [ charset "utf-8"; name "edsl" ] []
  ]
  body [ _class "pretty" ] [
    h1 [] [ text "I heart F#" ]
  ]
]
```

Use the provided code stubs as a starting point to:

1. Make a version which uses records and unions
2. Make a version which uses classes and inheritance.
3. Make a version which uses interfaces instead.
4. Make it produce JSON instead of HTML
5. Bonus: Make the "meta" tag accept only attributes and no elemets
6. Bonus: Make the EDSL more type safe, such that only particular attributes
   can be used with specific elements.

You don't have to pretty print the output, unless you want to challenge yourself
a little extra.

May the foo be with you!

