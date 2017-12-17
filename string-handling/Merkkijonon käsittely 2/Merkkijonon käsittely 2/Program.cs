using System;

namespace Merkkijonon_käsittely_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa käyttäjän syötteestä e kirjaimet @ merkiksi");
            Console.WriteLine("Syötä syöte:");
            while (true)
            {
                string errString = Console.ReadLine();
                string correctString = errString.Replace("e", "@");
                Console.WriteLine($"Syöte: {correctString}");
                break;
            }

            Console.ReadKey();
        }
    }
}
