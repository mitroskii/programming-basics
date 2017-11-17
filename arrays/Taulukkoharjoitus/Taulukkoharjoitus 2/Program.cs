using System;

namespace Taulukkoharjoitus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[,] array = new int[10, 20];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    //arvotaan luku
                    array[i, j] = rnd.Next(100);

                    if (array[i, j] < 10)
                    {
                        //tulostetaan luvut
                        Console.WriteLine($"[{i + 1}][{j + 1}]: 0{array[i, j]} ");
                    }
                    else
                        Console.WriteLine($"[{i + 1}][{j + 1}]: {array[i, j]} ");
                }
            }

                Console.ReadKey();
            }
        }
    }

