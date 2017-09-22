using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Define instructions
            Console.WriteLine("Ohjelma tulostaa positiivinen, negatiivinen tai nolla.");
            Console.WriteLine("Ohjelman suoritus loppuu komennolla get out");
            bool isNumber;
            do
            {

                Console.Write("Syötä luku: ");
                // define variables 
                string userInput;
                userInput = Console.ReadLine();

                int evaluatedNumber;
                isNumber = int.TryParse(userInput, out evaluatedNumber);

              if (userInput.ToUpper()=="GET OUT")
                {
                    Console.WriteLine("Ohjelman suoritus päättyy");
                    break;
                }
                
                
                // program logic
                if (isNumber == true)
                {
                    if (evaluatedNumber % 2 == 0)
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
                    }
                    else
                    {
                        Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
                    }
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
                    Console.WriteLine("Syötit muuta kuin numeroita!");
                }
            } while (true);
            

            Console.ReadKey();
        }
    }
}
