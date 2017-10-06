using System;

namespace toistorakenne2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee summan. Anna luku, summa lasketaan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            //int.TryParse(userInput, out int number);
            int i = 0;
            int f = 0;
            do
            {
                i = i + 1;
                f = f + i;
                
            } while (i < number);

            Console.WriteLine($"Syötit {i}\n vastaus {f}"); 
            Console.ReadKey();
        }
    }
}
