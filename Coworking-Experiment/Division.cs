using System;

namespace CoworkingExperiment
{
    class Division
    {
         public static double Div(double dividend, double divisor)
        {

    
            
                if (divisor == 0)
                {
                    throw new ArgumentException("Die Division darf nicht durch null sein.");
                }

                return dividend / divisor;
        }
    }




}