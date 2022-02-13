string harfNotu= Console.ReadLine();
int not = 0;
switch (harfNotu)
{
    case "AA":
        not = 85;
        break;
    case "BA":
        not = 75;
        break;
    case "BB":
        not = 65;
        break ;
    case "CC":
        not = 55;
        break;
    case "DC":
        not = 40;
        break;
    case "DD":
        not = 25;
        break;
}

Console.WriteLine($"{harfNotu} notunun taban puanı {not}");
Console.WriteLine($"{not} taban puanı {harfNotu} harf notunun karşılığıdır");
