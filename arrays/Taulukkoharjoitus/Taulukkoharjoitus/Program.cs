using System;

namespace Taulukkoharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                //arvotaan luku
                array[i] = rnd.Next(21);

                if ( array[i] < 10)
                {
                    //tulostetaan luvut
                    Console.WriteLine($"[{i + 1}]: 0{array[i]} ");
                }
                else
                    Console.WriteLine($"[{i + 1}]: {array[i]} ");
            }
                Console.ReadKey();
        }
    }
}
