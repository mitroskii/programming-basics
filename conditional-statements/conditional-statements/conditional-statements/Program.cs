﻿using System;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // define variables
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

                // program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber < 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen");
                    }
                    else if (evaluatedNumber > 0)
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on positiivinen");
                    }
                    else
                    {
                        Console.WriteLine($"Numero {evaluatedNumber} on nolla");
                    }
                }
                else
                {
                    Console.WriteLine("Syötit muuta kuin numeroita");
                }
            } while (isNumber == false);
            Console.ReadKey();
        }
    }
}
