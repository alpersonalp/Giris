


int deneme = 0;
do
{


    Console.WriteLine("UserName?");
    string username = Console.ReadLine();

    Console.WriteLine("Password?");
    string password = Console.ReadLine();

    if (username.ToLower() == "admin" && password.ToLower() == "123")
    {
        Console.WriteLine("Hoş geldin admin!");
        break;
    }

    else
    {
        Console.WriteLine($"{ ++deneme} bilgileriniz yanlış!");
    }

    if (deneme == 3)
        Console.WriteLine("Hesabınız Bloke Oldu");
  
} 
while (deneme < 3);
    
