let mutable x = 10
let mutable y = 20

let add x y = x + y

let z = add x y

printf "%d" z

let changeX x = x <- x + 10

changeX x

printf "%d" x