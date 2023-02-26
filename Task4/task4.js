let number = 2435
let a=0
let b=0
for(let i=0;i<4;i++)
{
    a=number%10
    b=b*10+a
    number=(number-a)/10
}
console.log(b)