using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarbugun = 7.55;
            double dolardun = 7.55;
            if (dolardun>dolarbugun)
            {
                Console.WriteLine("Dolar Azalıyor..");
            }
            else if(dolarbugun>dolardun)
            {
                Console.WriteLine("Dolar Düne Göre Daha Fazla");
            }
            else
            {
                Console.WriteLine("Dolar Aynı :(");
            }

            Console.WriteLine();
        }
    }
}
