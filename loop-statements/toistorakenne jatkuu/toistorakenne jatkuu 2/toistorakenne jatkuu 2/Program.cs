using System;

namespace toistorakenne_jatkuu_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9: ");

            for (int y = 1; y <= 9; y++)
            {
                for (int x = 1; x <= 9; x++)
                {
                    int tulos;
                    tulos = x * y;
                    Console.WriteLine($"{x}*{y} = {tulos}");
                }
            }
            Console.ReadKey();
        }
    }
}


