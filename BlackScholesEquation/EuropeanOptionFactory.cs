using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionPricing;


namespace OptionType
{

    /// <summary>
    /// Factory of Option's
    /// </summary>
    public class EuropeanOptionFactory: IOptionFactory
    {
        public Option create() {
            double r; // Interest rate
            double sig; // Volatility
            double K; // Strike price
            double T; // Expiry date
            double b; // Cost of carry
            string type; // Option name (call, put)

            Console.Write("Strike: ");
            K = Convert.ToDouble(Console.ReadLine());
            Console.Write("Volatility: ");
            sig = Convert.ToDouble(Console.ReadLine());
            Console.Write("Interest rate: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Cost of carry: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Expiry date: ");
            T = Convert.ToDouble(Console.ReadLine());
            Console.Write("1. Call, 2. Put: ");
            type = Convert.ToString(Console.ReadLine());


            Option opt = new Option(type, T, K, b, r, sig);
            return opt;
        }
       

    }
}
