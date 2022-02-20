/*string[] vs = { "BT AKADEMİ", "C#" };

string temp = vs[0];
vs[0] =vs[1];
vs[1] =temp;    

foreach (string v in vs)
    Console.WriteLine(v);
*/


string[] names = { "ekrem", "recep", "kaan" };

int result = Array.IndexOf(names, "kaan");
int result2 = Array.IndexOf(names, "sümeyye");
foreach(string name in names)
    Console.WriteLine(name);



char[] chars = new char[3];
chars[0] = 'A';
chars[1] = 'B';
chars[2] = 'C';

char[] temp = chars;
chars = new char[4];
for(int i = 0; i < temp.Length;i++)
    chars[i]=temp[i];

chars[3] = 'D';
foreach(char c in chars)
    Console.WriteLine(c);

