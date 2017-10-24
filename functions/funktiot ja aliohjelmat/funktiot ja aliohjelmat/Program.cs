using System;

namespace funktiot_ja_aliohjelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma pyytää yhden luvun ja palauttaa luvun tähtinä");
            int x;
            while (true)
            {
                Console.WriteLine("Tähtien lukumäärä");
                x = int.Parse(Console.ReadLine());

                if (x < 0)
                {
                    Console.WriteLine("Luku {0} ei ole sallittu luku", x);
                }
                else
                {
                    break;
                }
            }
            string stars = StarMachine(x);
            Console.WriteLine($" Syötit luvun {x}. Sait tähtiä {stars}");
            Console.ReadKey();
        }
        static string StarMachine(int numberOfStarts)
        {
            string res = string.Empty;
            for (int i = 0; i < numberOfStarts; i++)
            {
                res += "*";
            }
            return res;
        }
    }
}
