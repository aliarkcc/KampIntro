using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1,"Mehmet");
            dictionary.Add(2, "Salih");
            dictionary.Add(3, "Cemile");
            dictionary.Add(4, "Murat");


            Console.WriteLine(dictionary.Lenght);
        }
    }
}
