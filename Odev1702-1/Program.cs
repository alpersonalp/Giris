int a = 3;
int b = 2;


b = b + a;
a = b - a;
b = b - a;

Console.WriteLine($"a'nın değeri {a}"); // 2
Console.WriteLine($"b'nin değeri {b}"); // 3