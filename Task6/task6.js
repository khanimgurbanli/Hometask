let number=234
let i=0
let a=0
while(number!=0)
{
    i=i+1;
    a=number%10
    number=(number-a)/10
}
if(i==3)
    {console.log(true)}
else
    {console.log(false)}
