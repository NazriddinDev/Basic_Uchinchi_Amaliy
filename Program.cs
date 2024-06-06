using System;
// // Tub sonlar
// int n;
// Console.Write("Son kiriting=> ");
// n=Convert.ToInt32(Console.ReadLine());
// if (n == 2)
// {
//     Console.WriteLine("Tub son...");
// }
// else if (n == 3)
// {
//     Console.WriteLine("Tub son...");
// }
// else if (n == 5)
// {
//     Console.WriteLine("Tub son...");
// }
// else if(n%2==0||n%3==0||n%4==0||n%5==0)
// {
//     Console.WriteLine("Tub son emas...");
// }
// else Console.WriteLine("Tub son...");

// //Bo'luvchisiz sonlar
// int k;
// Console.Write("Son kiriting=> ");
// k=Convert.ToInt32(Console.ReadLine());
// for(int i=2; i<k; i++)
// {
//     if(k%i==0)
//     {
//         Console.WriteLine(i);
//     }

// }

// // Daraja hisoblash
// int a,b;
// Console.Write("Son kiriting=> ");
// a=Convert.ToInt32(Console.ReadLine());
// Console.Write("darajani kiriting=> ");
// b=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Natija=> {Math.Pow(a,b)}");

// // Hujjatlar to'plamini hisoblash
// int c, S=0;
// Console.Write("To'plam sonini kiriting=> ");
// c = int.Parse(Console.ReadLine());
// int q = c;
// int[] toplam= new int[c];
// for(int i=0; i<c; i++)
// {
//     Console.Write($"Siz {q} ta top'lam kiritishingiz kerak=> ");
//     toplam[i]=int.Parse(Console.ReadLine());
//     S+=toplam[i];
//     q--;
// }
// Console.WriteLine($"{c} ta to'plamlar yig'indisi=> {S}");

// Armstrong sonlar
int b, f, j, k, l, m, i=0;
double S;
Console.Write("Armstrong sonni kiriting=> ");
j=Convert.ToInt32(Console.ReadLine());
k=j;
do
{
    k = k/10;
    i++ ;
}
while(k>9);
    Console.WriteLine($"Kiritilgan son {++i} xonali...");
   if(i==3)
   {
        l=j%10;
        m=j/10;
        f=m%10;
        b =m/10;
        S=Math.Pow(b,i)+Math.Pow(f,i)+Math.Pow(l,i);
        Console.WriteLine($"S= {S}");
        if(S==j)
        {
            Console.WriteLine("Armstrong son...");
        }
        else
        {
            Console.WriteLine("Armstrong son emas...");

        }
   }