// Kullanıcıdan 5 adet benzersiz sayı alalım..
// bu sayıların;
// en büyüğünü
// en küçüküğünü
// ortalamasını ekrana yazdıralım..

// Ödev: bu örneğin aynısını for döngüsü ile yapınız.. Not : for'un yapısını bozmadan...
//for(int i=0; i<sayis.Length;i++)


int n = 5;
int[] sayis = new int[n];

int i = 0;
for (i=0; i< sayis.Length; i++)
{

  
    Console.WriteLine($"Lütfen ({i + 1}). sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (Array.IndexOf(sayis, sayi) == -1) // sayi'yi sayisde ara..
    {
        sayis[i] = sayi;
    }
}
Console.WriteLine($"en büyüğü {sayis.Max()}");
Console.WriteLine($"en küçüüğü {sayis.Min()}");
Console.WriteLine($"ortalaması {sayis.Average()}");