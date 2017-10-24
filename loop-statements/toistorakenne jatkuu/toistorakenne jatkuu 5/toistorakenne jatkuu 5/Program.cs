using System;

namespace toistorakenne_jatkuu_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin, 13 kohdetta X 1 tai 2");
            Random rnd = new Random();
            double y;
            for (int x = 1; x < 14; x++)
            {
                y = rnd.NextDouble();
                if (y <= 0.4)
                {
                    Console.WriteLine("1");
                }
                else if (y > 0.6)
                {
                    Console.WriteLine("2");
                }
                else
                {
                    Console.WriteLine("x");
                }
            }
            Console.ReadKey();
        }
    }
}
