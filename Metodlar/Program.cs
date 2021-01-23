using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            

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
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }


            Console.WriteLine("-------------Metotlar-----------");

            //instance-örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Kırmızı Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
