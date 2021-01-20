using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetiştime Kampı";
            string kurs2 = "Programlamaya Baslangic Icin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi 

            string[] kurslar = new string[] { "Yazılım Gelistirici Yetiştime Kampı",
                "Programlamaya Baslangic Icin Temel Kurs", "Java","Python","c#" };
            
           //dizileri dönmek için 1.yöntem

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");
            //dizileri dönmek için en kısa yöntem

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu- footer");
        }
    }
}
