string[] isimler = new string[3];
isimler[0] = "Recep";
isimler[1] = "Ekrem";
isimler[2] = "Emre";

char[] karakterler = new char[5];
karakterler[0] = 'E';
karakterler[1] = 'K';
karakterler[2] = 'R';
karakterler[3] = 'E';
karakterler[4] = 'M';

bool[] durumlar = new bool[3];
durumlar[0] = true;
durumlar[1] = false;
durumlar[2] = true;

string[] ogrenciler = new string[4];
ogrenciler[0] = "Kaan";
ogrenciler[1] = "Bilal";
ogrenciler[2] = "Nur";
ogrenciler[3] = "Sümeyye";

byte[] bytler = new byte[500];

foreach (string isim in isimler)
{
    Console.WriteLine(isim);
}

foreach (char k in karakterler)
{
    Console.WriteLine(k);
}

foreach (bool d in durumlar)
{
    Console.WriteLine(d);
}

foreach (string ogrenci in ogrenciler)
{
    Console.WriteLine(ogrenci);
}



int l = isimler.Length - 1;
while (l >= 0)
{
    Console.WriteLine(isimler[l--]);
}

int ji = karakterler.Length;


while (ji > 0)
{
    Console.WriteLine(karakterler[ji-1]);
    ji--;
}





