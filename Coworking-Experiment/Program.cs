using System;
<<<<<<< Updated upstream
using System.ComponentModel;
=======
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
>>>>>>> Stashed changes

namespace CoworkingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            
=======
            Console.Title = "Taschenrechner";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKey key = ConsoleKey.None;

            do
            {
                Console.Clear();
                Console.WriteLine("Taschenrechnerprogramm");
                Console.WriteLine("*Komma bitte als Punkt schreiben*");
                Console.Write("Bitte 1. Zahl eingeben: ");
                Double.TryParse(Console.ReadLine(), out double a);
                Console.Write("Bitte Rechenzeichen eingeben (+, -, *, /): ");
                string z = Console.ReadLine();
                Console.Write("Bitte 2. Zahl eingeben: ");
                Double.TryParse(Console.ReadLine(), out double b);

                double ergebnis = 0;

                switch (z)
                {
                    case "+":
                        ergebnis = Addition.Add(a, b);
                        break;
                    case "-":
                        ergebnis = Subtraktion.Sub(a, b);
                        break;
                    case "*":
                        ergebnis = Multiplikation.Mul(a, b);
                        break;
                    case "/":
                        ergebnis = Division.Div(a, b);
                        break;
                    default:
                        break;
                }
                if (z == "*" || z == "-" || z == "*" || z == "/")
                {
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    Console.Write("Nochmal? (j/n) ");
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.N)
                    {
                        break;
                    }
                }
            } while (key != ConsoleKey.N);
>>>>>>> Stashed changes
        }
    }
}
