


int ogrenci;
Console.Write("Sınıfta Kaç Öğrenci Var? : ");
ogrenci = Convert.ToInt32(Console.ReadLine());



float endusukort = 100, enbuyukort = 0, SinifToplam = 0;


for (int i = 0; i < ogrenci; i++)
{
    Console.Write($"{ i + 1} . Vize Notunu Giriniz : ");
    float vizeNotu = Convert.ToSingle(Console.ReadLine());
    Console.Write($"{ i + 1} . Final Notunu Giriniz : ");
    float finalNotu = Convert.ToSingle(Console.ReadLine());


    float ort = (vizeNotu * 0.4f) + (finalNotu * 0.6f);
    Console.WriteLine("Ortalama = " + ort);



    if (ort > enbuyukort)
        enbuyukort = ort;

    if (ort < endusukort)
        endusukort = ort;

    SinifToplam += ort;



}

SinifToplam = SinifToplam / ogrenci;

Console.WriteLine($"En Yüksek Öğrenci Ortalaması = {enbuyukort}");
Console.WriteLine($"En Düşük Öğrenci Ortalaması = {endusukort}"); 
Console.WriteLine($"Sınıf Ortalaması =  {SinifToplam}");
