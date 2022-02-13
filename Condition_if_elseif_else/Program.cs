Console.WriteLine("1.Sayıyı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.Sayıyı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi > sayi2)
{
    Console.WriteLine("1. Sayı Büyüktür");
}
else if (sayi < sayi2)
{
    Console.WriteLine("2.Sayı Büyüktür");
}
else
{
    Console.WriteLine("Sayılar Eşittir");
}

Console.WriteLine("Program doğru sonucu buldu...");

