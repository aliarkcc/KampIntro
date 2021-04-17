using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklendi..");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silindi..");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Listelendi..");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Guncellendi...");
        }
    }
}
