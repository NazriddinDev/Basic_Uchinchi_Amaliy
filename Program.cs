using System;
// Tub sonlar
int n;
Console.Write("Son kiriting=> ");
n=Convert.ToInt32(Console.ReadLine());
if (n == 2)
{
    Console.WriteLine("Tub son...");
}
else if (n == 3)
{
    Console.WriteLine("Tub son...");
}
else if (n == 5)
{
    Console.WriteLine("Tub son...");
}
else if(n%2==0||n%3==0||n%4==0||n%5==0)
{
    Console.WriteLine("Tub son emas...");
}
else Console.WriteLine("Tub son...");

//