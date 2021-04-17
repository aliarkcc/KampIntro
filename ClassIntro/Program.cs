using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mehmet";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C";
            kurs1.Egitmen = "Mehmet Ali Arkac";
            kurs1.IzlenmeOranı = 44;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Visual Basic";
            kurs2.Egitmen = "Serdar Sert";
            kurs2.IzlenmeOranı = 44;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Zafer Aydemir";
            kurs3.IzlenmeOranı = 44;


            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine(item.KursAdi+" " + item.Egitmen);
            }

            //Console.WriteLine(kurs1.KursAdi+" Dersini "+kurs1.Egitmen + " Veriyor");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
