using System;

namespace funktiot_ja_aliohjelmat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int retNumber = numberFromRange(50,500);
            Console.WriteLine($"Syöttämäsi luku {retNumber} on sallittu");
            Console.ReadKey();
        }
        static int numberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input = 0;
            int ret = 0;
            do
            {
                Console.Write("Syötä numero väliltä 50-500: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);
                if (input >= lowerBound && input <= upperBound)
                {
                    ret = input;
                    break;
                }
                else
                {
                    isNumber = false;
                    Console.WriteLine("Numerosi ei ole sallittu, aloita alusta");
                }
            }
            while (isNumber == false);

            return ret;
        }
    }
}
