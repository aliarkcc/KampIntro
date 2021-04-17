using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri()
            {
                MusteriID = 1,
                MusteriAdi = "Mehmet Ali",
                MusteriSoyadi = "Arkac",
                MusteriTelNo = "5555555555",
                MusteriAdres = "Antalya"
            };

            MusteriManager musteriManager = new MusteriManager();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hangi İşlemi Yapmak İstiyorsunuz?");
                Console.WriteLine("1 Ekle -- 2 Sil -- 3 Guncelle -- 4 Listele");
                int deger = int.Parse(Console.ReadLine());
                switch (deger)
                {
                    case 1:
                        musteriManager.Ekle(musteri);
                        break;
                    case 2:
                        musteriManager.Sil(musteri);
                        break;
                    case 3:
                        musteriManager.Guncelle(musteri);
                        break;
                    case 4:
                        musteriManager.Listele(musteri);
                        break;
                    default:
                        Console.WriteLine("1-4 arası deger seciniz..");
                        break;
                } 
            }

            Console.WriteLine();
        }
    }
}
