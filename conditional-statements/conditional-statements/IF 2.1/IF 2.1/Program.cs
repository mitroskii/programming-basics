using System;

namespace IF_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Maatalousnäyttelyn lipunhinta");

            Console.Write("Ikä: ");
            int ikä = int.Parse(Console.ReadLine());
            if (ikä < 7)
                Console.Write("Lippu on ilmainen");
            if (ikä >= 7 && ikä <= 15)
                Console.Write("Lippu maksaa 8.00€");
            if (ikä >= 65)
                Console.Write("Lippu maksaa 8.00€");

            if (ikä > 15 && ikä < 65)
                
            {
                Console.WriteLine("Oletko varusmies?");
                Console.Write("");
                string userInput = Console.ReadLine();
                if (Console.ReadLine() == "Kyllä")
                    Console.WriteLine("Lippu maksaa 8.00€");
                else
                {
                    Console.WriteLine("Oletko opiskelija?");
                    Console.Write("");
                    if (Console.ReadLine() == "Kyllä")
                        Console.WriteLine("Oletko Mtk jäsen?");
                    Console.Write("");
                    if (Console.ReadLine() == "Kyllä")
                        Console.WriteLine("Lippu maksaa 6.40€");
                
                    else
                    {
                        Console.WriteLine("Oletko opiskelija?");
                        Console.Write("");
                        if (Console.ReadLine() == "Kyllä")
                            Console.WriteLine("Lippu maksaa 8.80€");

                        else
                        {
                            Console.WriteLine("Oletko Mtk jäsen?");
                            Console.Write("");
                            if (Console.ReadLine() == "Kyllä")
                                Console.WriteLine("Lippu maksaa 13.60€");
                        }
                    }
                }
            }
                Console.ReadKey();
            }
        }
    }

   
