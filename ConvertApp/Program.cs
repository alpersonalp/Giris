Console.WriteLine("Adınız?");

String ad= Console.ReadLine();

Console.WriteLine("Hoş Geldin! " + ad);


int sayi1, sayi2;
Console.WriteLine("1. Sayıyı Giriniz");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı Giriniz");
sayi2 = Convert.ToInt32(Console.ReadLine());

int sonuc = sayi1 - sayi2;
Console.WriteLine("İşlem sonucu" + sonuc);