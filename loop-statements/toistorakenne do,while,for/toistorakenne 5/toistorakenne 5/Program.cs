using System;

namespace toistorakenne_5
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
            int f = 1;
            int evenSum = 0;
            int oddSum = 0;
            if (number < 0)
            {
                f = -1;
            }

            do
            {
                if (i % 2 == 0)
                    evenSum += i;
                else
                    oddSum += i;
                i++;
            }
            while (i <= number * f);
            Console.WriteLine($"Parillisten lukujen summa = {evenSum * f} ja parittomien lukujen summa = {oddSum * f}");
            Console.ReadKey();

        }
    }
}
