using System;

namespace CoworkingExperiment
{
    class Division
    {
         public static double Div(double a, double b)
        {
                if (a == 0 || b == 0)
                {
                    throw new ArgumentException("Die Division darf nicht durch null sein.");
                }

                return a / b;
        }
    }

}