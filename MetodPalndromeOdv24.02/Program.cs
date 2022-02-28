class Program
{

    static void Main(string[] args)
    {
        string cumle = "bu gün hava çok güzel arkadaşlar ile pinkik yapmaya gittik orada kavak ağaçları vardı çıkmadan önce elbiselerime ütü yaptım";

        string[] palindroms = cumle.Split(' ');

        foreach (var item in palindroms)
        {

            if (IsPalindrome(item))
                Console.WriteLine(item);
        }
        static string Palindrome(string kelime)
        {
            char[] temp = kelime.ToCharArray();
            Array.Reverse(temp);

            return new string(temp);
        }

        static bool IsPalindrome(string kelime)
        {
            bool durum = Palindrome(kelime) == kelime ? true : false;
            return durum;
        }
    }
}

