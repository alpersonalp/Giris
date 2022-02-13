

Console.WriteLine("Bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi == 0)
{
    Console.WriteLine("Sayı 0");
}
else if (sayi >= 0 && sayi <= 100)
{
    Console.WriteLine("Sayı Pozitif");
}
else
{
    Console.WriteLine("Sayı Negatiftir");
}