using System;

namespace toistorakenne_jatkuu_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Ohjelma simuloi rahan heittoa, syötä luku: ");
            int.TryParse(Console.ReadLine(), out int n);
            int kruuna = 0;
            int klaava = 0;
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                if (rnd.Next(2) == 1)
                {
                    kruuna++;
                }
                else
                {
                    klaava++;
                }
                // Console.WriteLine(i);
            }
            Console.WriteLine($"Kolikkoa on heitetty {n} kertaa.\nKlaavoja tuli {klaava} kruunia tuli {kruuna}");
            Console.ReadKey();
        }
    }
}
