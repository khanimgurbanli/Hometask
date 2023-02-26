let n = 2332
let b
let c=0
let d = n
for ( i=0; i < 4; i++)
{
    b = n % 10
    c = c * 10 + b
    n=(n-b)/10
}
if (c == d)
{
    console.log("Yes")
}
else 
{
    console.log("No")
}

