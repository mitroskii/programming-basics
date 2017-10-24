using System;

namespace toistorakenne_jatkuu_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa ja laskee kuutosen esiintymismäärän");
            int x;
            int y = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 1000; i++)
            {
                x = rnd.Next(1, 7);
                if (x == 6)
                    y++;
            }
            Console.WriteLine($"Heitit noppaa 1000 kertaa, sait kutosen {y} kertaa");
            Console.ReadKey();
        }
    }
}
