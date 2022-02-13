/*
 *                                   rmek istersin?");
string mesaj = Console.ReadLine();

Console.WriteLine("Kaç Defa Yazdıralım?");
int n = Convert.ToInt32(Console.ReadLine());

 for (int i = 0; i < n; i++)
{
    Console.WriteLine($"{i + 1} . {mesaj}");

}

for (int i = 1; i<=10; i++)
{
Console.WriteLine(i);
}


for (int x = 10; x >= 1; x--)
{
    Console.WriteLine(x);
}


*/
Console.WriteLine("Hangi Mesajı Vermek İstersin???");
string mesaj = Console.ReadLine();

Console.WriteLine("Kaç Defa Yazdıralım???");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    //Console.WriteLine( (i + 1) + mesaj);
    Console.WriteLine($"{i + 1} . {mesaj}");
}




