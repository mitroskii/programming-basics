using System;

namespace toistorakenne_jatkuu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma tulostaa kokonaislukujen 1-10 neliöjuuret: ");
            int i = 1;
            do
            {
                Console.WriteLine($"{i}  {Math.Round(Math.Sqrt(i),2)}");
                i++;
            }
            while (i < 11);
            Console.ReadKey();
        }
    }
}
