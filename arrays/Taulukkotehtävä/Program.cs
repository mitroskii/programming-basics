using System;

namespace Taulukkotehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] iT = new int[100];
            Random rnd = new Random();
            double sum = 0;
            // Lukujen arvonta - alustetaan taulukko
            for (int i = 0; i < 100; i++)
            {
               iT[i] = rnd.Next(51);

            }
            // Laske summa ja keskiarvo
            for (int i = 0; i < 100; i++)
            {
                sum = sum + iT[i];
            }

            Console.WriteLine($"Lukujen keskiarvo = {sum / 100} ");
            Console.WriteLine($"Lukujen summa = {sum}");
            Console.ReadKey();
        }
    }
}
