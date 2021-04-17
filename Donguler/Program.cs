using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılımcı Geliştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç için temel kurs";
            string kurs3 = "Java";

            string[] kurslar = new string[] { "Yazılımcı Geliştirme Kampı", "Programlamaya Başlangıç için temel kurs", "Java" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.Write(kurslar[i]);
            }
        }
    }
}
