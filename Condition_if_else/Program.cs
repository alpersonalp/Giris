﻿int sayi1, sayi2;

Console.WriteLine("1. Sayıyı giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

int enb = 0;

if ( sayi1 > sayi2)
{
    enb = sayi1;
}
else
{
    enb = sayi2;
}
Console.WriteLine("En büyük sayı= " + enb); 

if (sayi1 > sayi2)
{
    Console.WriteLine("En büyük sayı= " + sayi1);
}
else
{
    Console.WriteLine("En büyük sayı= " + sayi2);


}
