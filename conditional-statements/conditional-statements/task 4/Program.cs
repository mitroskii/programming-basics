using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen");
            bool isNumber;
            Console.Write("Syötä luku X: ");
           
            Console.Write("Syötä luku Y: ");

            Console.Write("Syötä luku Z: ");
            string userInput;
            userInput = Console.ReadLine();

            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);



            Console.ReadKey();
        }
    }
}
