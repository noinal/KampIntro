using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artıs Butonu");

            }
            else
            {
                Console.WriteLine("degismedi Butonu");
            }
          
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);



        }
    }
}
