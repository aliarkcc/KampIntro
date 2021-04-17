using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double urunFiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 4;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 2;
            urun2.Aciklama = "Adana Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Urunun Adı:"+urun.Adi+ " Urunun Fiyatı:"+urun.Fiyati+ " Urunun Açıklaması:"+urun.Aciklama);
            }


            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle2("Elma", "Amasya Elması", 3);
            Console.WriteLine("Hello World!");
        }
    }
}


// do not repeat yourself