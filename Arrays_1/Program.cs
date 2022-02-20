string str1 = "Recep";
string str2 = "Sümeyye";
string str3 = "Alper";
string str4 = "Kaan";
string str5 = "Emre";

Console.WriteLine(str1);
Console.WriteLine(str2);
Console.WriteLine(str3);
Console.WriteLine(str4);
Console.WriteLine(str5);

Console.WriteLine("******************************************");


string[] names = new string[5];
names[4] = "Recep";
names[0] = "Sümeyye";
names[1] = "Alper";
names[2] = "Kaan";
names[3] = "Emre";

for(int i=0; i<5; i++)
    Console.WriteLine(names[i]);