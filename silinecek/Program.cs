using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double vizeNotu, finalNotu, ogrenci, ort, Sort = 0;
            Console.Write("Sınıf Mevcudunu Giriniz : ");
            ogrenci = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <= ogrenci; i++)
            {
                Console.Write("Vize Notunu Giriniz = ");
                vizeNotu = Convert.ToDouble(Console.ReadLine());
                Console.Write("Final Notunu Giriniz = ");
                finalNotu = Convert.ToDouble(Console.ReadLine());
                ort = vizeNotu * 0.4 + finalNotu * 0.6;
                Console.WriteLine("Ortalama = " + ort);
                if (ort < 50)
                {
                    Console.WriteLine("Öğrenci Kaldı ");
                }
                else
                    Console.WriteLine("Öğrenci Geçti ");
                Sort = Sort + ort;
            }
            Console.Write("Sınıf Ortalaması = " + (Sort / ogrenci));
            Console.ReadKey();
        }

    }
}