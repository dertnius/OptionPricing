using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFunctions
{
    public class Functions
    {
        /// <summary>
        /// Standar normal distribition, probability density function
        /// </summary>
        /// <param name="x"></param>
        /// <returns>double valor computed</returns>
        static public double n(double x)
        {

            double A = 1.0 / Math.Sqrt(2.0 * 3.1415);
            return A * Math.Exp(-x * x * 0.5);
        }


        /// <summary>
        /// Computes the Gaussian Normal cumulative distribution function 
        /// </summary>
        /// <param name="x">input double parameter</param>
        /// <returns>value for this point</returns>
        static public double N(double x)
        {

            try
            {
                double a1 = 0.4361836;
                double a2 = -0.1201676;
                double a3 = 0.9372980;

                double k = 1.0 / (1.0 + (0.33267 * x));
                if (x >= 0.0)
                {
                    return 1.0 - n(x) * (a1 * k + (a2 * k * k) + (a3 * k * k * k));
                }
                else
                {
                    return 1.0 - N(-x);
                }

            }
            catch (DivideByZeroException)
            {

         
                return -1;
            }


        }



    }


}
