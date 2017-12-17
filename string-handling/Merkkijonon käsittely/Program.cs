using System;

namespace Merkkijonon_käsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa käyttäjän syöttämästä syötteestä merkkien lukumäärän");
            Console.WriteLine("Syötä syöte:");
            while (true)
            {
                string userInput = Console.ReadLine();
                Console.WriteLine($"Syötteessä on {userInput.Length} merkkiä");
                break;
            }
            
            Console.ReadKey();
            
        }
    }
}
