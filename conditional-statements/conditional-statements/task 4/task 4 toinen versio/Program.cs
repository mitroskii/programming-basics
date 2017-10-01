using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Syötä luku X: ");
            string userInput;
            userInput = Console.ReadLine();
            int lukuX;
            lukuX = int.Parse(userInput);

            Console.WriteLine("Syötä luku Y: ");
            string userInput2;
            userInput2 = Console.ReadLine();
            int lukuY;
            lukuY = int.Parse(userInput2);

            Console.WriteLine("Syötä luku Z: ");
            string userInput3;
            userInput3 = Console.ReadLine();
            int lukuZ;
            lukuZ = int.Parse(userInput3);



            if (lukuX < lukuY)
                if (lukuX < lukuZ)
                    if (lukuY < lukuZ)
                    {
                        Console.WriteLine("Vastaus: ");
                        Console.Write(userInput);
                        Console.Write(", ");
                        Console.Write(userInput2);
                        Console.Write(", ");
                        Console.Write(userInput3);


                    }
            if (lukuX < lukuY)
                if (lukuX > lukuZ)
                {
                    Console.WriteLine("Vastaus: ");
                    Console.Write(userInput3);
                    Console.Write(", ");
                    Console.Write(userInput);
                    Console.Write(", ");
                    Console.Write(userInput2);


                }


            if (lukuX < lukuY)
                if (lukuX < lukuZ)
                    if (lukuY > lukuZ)
                    {
                        Console.WriteLine("Vastaus: ");
                        Console.Write(userInput);
                        Console.Write(", ");
                        Console.Write(userInput3);
                        Console.Write(", ");
                        Console.Write(userInput2);


                    }
            if (lukuX > lukuY)
                if (lukuX < lukuZ)
                {
                    Console.WriteLine("Vastaus: ");
                    Console.Write(userInput2);
                    Console.Write(", ");
                    Console.Write(userInput);
                    Console.Write(", ");
                    Console.Write(userInput3);


                }

            if (lukuX > lukuY)
                if (lukuX > lukuZ)
                    if (lukuY > lukuZ)
                    {
                        Console.WriteLine("Vastaus: ");
                        Console.Write(userInput3);
                        Console.Write(", ");
                        Console.Write(userInput2);
                        Console.Write(", ");
                        Console.Write(userInput);


                    }
            if (lukuX > lukuY)
                if (lukuX > lukuZ)
                    if (lukuY < lukuZ)
                    {
                        Console.WriteLine("Vastaus: ");
                        Console.Write(userInput2);
                        Console.Write(", ");
                        Console.Write(userInput3);
                        Console.Write(", ");
                        Console.Write(userInput);
                    }

            Console.ReadKey();

        }
    }
}



