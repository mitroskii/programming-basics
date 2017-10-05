using System;

namespace IF_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");
            int price = 16;
            float discount = 0.0f;


            Console.Write("Ikä: ");
            int ikä = int.Parse(Console.ReadLine());
            if (ikä < 7)
                Console.Write("Lippu on ilmainen");
            if (ikä >= 7 && ikä <= 15)
                Console.Write($"Lippu maksaa {price*0.5}€");
            if (ikä >= 65)
                Console.Write($"Lippu maksaa {price * 0.5}€");

            if (ikä > 15 && ikä < 65)
            {
                Console.Write("Oletko varusmies? [Y/N]: ");

                if (Console.ReadLine().ToUpper() == "Y")
                    Console.Write($"Lippu maksaa {price * 0.5}€");
                else
                {                    
                    Console.Write("Oletko Mtk jäsen? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                        discount = 0.15f;                       

                    Console.Write("Oletko opiskelija? [Y/N]: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        discount = discount + 0.45f;
                    }
                    Console.WriteLine($"lippusi hinta on {price - price * discount}€");
                }
            }
                Console.ReadKey();
            }
        }
    }

   
