using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace CoworkingExperiment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Taschenrechner";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKey key;

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
                key = ConsoleKey.None;

                switch (z)
                {
                    case "+":
                        ergebnis = Addition.Add(a, b);
                        break;
                    case "-":
                        ergebnis = Subtraktion.Subtrahieren(a, b);
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
                if (z.Equals("*") || z.Equals("-") || z.Equals("*") || z.Equals("/"))
                {
                    Console.WriteLine("Das Ergebnis lautet: {0}", ergebnis);
                    Console.Write("Beliebige Taste für Neustart...");
                    key = Console.ReadKey().Key;
                    if (key == ConsoleKey.N)
                    {
                        break;
                    }
                }
            } while (key != ConsoleKey.N);
        }
    }
}
