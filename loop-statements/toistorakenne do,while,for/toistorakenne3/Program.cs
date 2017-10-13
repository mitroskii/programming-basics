
using System;

namespace toistorakenne3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma laskee parillisten ja parittomien summan. Anna luku, summat lasketaan: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            int i = 0;
            int f = 0;
            int evenSum = 0;
            int oddSum = 0;
            do
            {
                if (i % 2 == 0)
                    evenSum += i;
                else
                    oddSum += i;
                i++;
            }
            while (i <= number);

            Console.WriteLine($"Parillisten lukujen summa = {evenSum} ja parittomien lukujen summa = {oddSum}");
            Console.ReadKey();
        }
    }
}
