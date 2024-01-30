using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operatie? ");

            string answer = Console.ReadLine();
            // Optellen
            if (answer == "+")
            {
                Console.WriteLine("Eerste getal? ");
                int getal1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Tweede getal? ");
                int getal2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultaat: " + (getal1 + getal2));
            }
            // Aftrekken
            else if (answer == "-")
            {
                Console.WriteLine("Eerste getal? ");
                int getal1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Tweede getal? ");
                int getal2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultaat: " + (getal1 - getal2));
            }
            // Vermenigvuldigen
            else if (answer == "*")
            {
                Console.WriteLine("Eerste getal? ");
                int getal1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Tweede getal? ");
                int getal2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultaat: " + (getal1 * getal2));
            }
            // Delen
            else if (answer == "/")
            {
                Console.WriteLine("Eerste getal? ");
                double getal1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Tweede getal? ");
                double getal2 = double.Parse(Console.ReadLine());

                if (getal2 == 0)
                {
                    Console.WriteLine("Kan niet delen door 0");
                }
                else
                {
                    Console.WriteLine("Resultaat: " + getal1 / getal2);
                }
            }
            else
            {
                Console.WriteLine("Ongeldige operatie");
            }
        }
    }
}
