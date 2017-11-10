using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] lotto = new int[9];
            Random rnd = new Random();
            for (int i = 0; i < lotto.Length - 1; i++)
            {
                // Arvotaan luku väliltä 1-40
                lotto[i] = rnd.Next(41);

                // Tarkistetaan onko luku jo arvottu aiemmin
                for (int j = 0; j < i; j++)
                {
                    if (lotto[j] == lotto[i])
                    {
                        i--;
                    }
                }
            }
            // Arvotaan tuplausnumero
            lotto[8] = rnd.Next(41);

            // Järjestetään taulukon ensimmäiset 7 numeroa pienimmästä suurimpaan
            Array.Sort(lotto, null, 0, 7);

            // Tulostetaan luvut 1-7
            for (int i = 0; i < lotto.Length - 2; i++)
            {
                Console.WriteLine($"Lottirivi:");
                Console.WriteLine($"{i + 1}: {lotto[i]} ");
            }

            Console.WriteLine($"Lisänumero: {lotto[7]}\nTuplausnumero: {lotto[8]}");
            Console.ReadKey();
        }
    }
}
