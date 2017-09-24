using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Syötä numero: ");
            String userInput;
            userInput = Console.ReadLine();
            int luku1;
            luku1 = int.Parse(userInput);

            Console.WriteLine("Syötä numero: ");
            String userInput2;
            userInput2 = Console.ReadLine();
            int luku2;
            luku2 = int.Parse(userInput2);

            Console.WriteLine("Syötä numero: ");
            String userInput3;
            userInput3 = Console.ReadLine();
            int luku3;
            luku3 = int.Parse(userInput3);

            int[] numbers = { luku1, luku2, luku3 };

            Console.Write("Vastaus: ");

            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.Write(number);
                Console.Write(' ');
            }
            Console.ReadKey();
        }
    }
}
