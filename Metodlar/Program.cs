using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpu";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";


            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {

            }



          


            Console.WriteLine("Hello World!");
        }
    }
}
