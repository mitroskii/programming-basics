using System;

namespace silmukka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee kertoma. Anna luku, jonka kertoma lasketaan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 1;
            do
            {
                i = i + 1;
                f = f * i;
                //Console.WriteLine($"{i} kertoma on yhtäsuuri kuin{f}"); // 5!=120
            } while (i < number);

            Console.WriteLine($"Syötit {i}\n vastaus {f}"); // 5!=120
            Console.ReadKey();
        }
    }
}
