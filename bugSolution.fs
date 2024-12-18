let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d\n" z

let changeX () = x <- x + 10

changeX ()

printf "%d" x