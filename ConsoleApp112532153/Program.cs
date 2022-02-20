using System.Linq;

using System.Text;

namespace ConsoleApp112532153

{

    class Program

    {

        static void Main(string[] args)

        {

            int i, j, vize, final;

            double sonuc;





            Console.WriteLine("Kaç Öğrencinin Notları Girilecek");

            i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Toplam " + i + " öğreninin notu girilecek");

            for (j = 1; j <= i; j++)

            {

            bas:

                Console.WriteLine(j + ". Öğrencinin Vize Notunu Gİrin");

                vize = Convert.ToInt32(Console.ReadLine());

                if (vize < 0 || vize > 100)

                {

                    Console.WriteLine("Vize Notu Hatalı Girildi Lütfen Tekrar Giriniz");



                    goto bas;

                }

            basb:



                Console.WriteLine(j + ". Final Notunu Girin");

                final = Convert.ToInt32(Console.ReadLine());

                if (final < 0 || final > 100)

                {

                    Console.WriteLine("Final Notu Hatalı Girildi Lütfen Tekrar Giriniz");

                    goto basb;

                }



                sonuc = vize * 0.4 + final * 0.6;

                Console.WriteLine(j + ". Öğrencinin Not Ortalaması= " + sonuc);

            }

        }

    }

}