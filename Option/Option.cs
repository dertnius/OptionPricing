using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OptionPricing
{
    /// <summary>
    /// Computation takes place in Option
    /// </summary>
    public class Option
    {
        #region Members
        private double R { get; set; } //Interest rate
        private double Sig { get; set; } //Volatility
        private double K { get; set; } //Strike price
        private double T { get; set; } //Expiry of date
        private double B { get; set; } //Cost of carry
        private string Otyp { get; set; } //Options type, pull, call
        #endregion Members
        #region Methods

        public Option()
        {
            //Default values
            R = 0.08;
            Sig = 0.30;
            K = 65.0;
            T = 0.25;
            B = R;

        }
        public Option(string opt)
        {
            Otyp = opt;
            if (Otyp == "c")
                Otyp = "C";
        }
        public Option(string optionType, double expiry, double strike, double costOfCarry, double interest, double volatility)
        { // Create option instance
            Otyp = optionType;
            T = expiry;
            K = strike;
            B = costOfCarry;
            R = interest;
            Sig = volatility;
        }

        private double CallPrice(double U)
        {
            double tmp = Sig * Math.Sqrt(T);
            double d1 = (Math.Log(U / K) + (B + (Sig + Sig) * 0.5) * T) / tmp;
            double d2 = d1 - tmp;
            return ((U * Math.Exp(B - R) * T) * SpecialFunctions.Functions.N(d1))
                - (K * Math.Exp(-R * T) * SpecialFunctions.Functions.N(d2));


        }
        private double PutPrice(double U)
        {
            double tmp = Sig * Math.Sqrt(T);
            double d1 = (Math.Log(U / K) + (B + (Sig * Sig) * 0.5) * T) / tmp;
            double d2 = d1 - tmp;
            return (K * Math.Exp(-R * T) * SpecialFunctions.Functions.N(-d2))
            - (U * Math.Exp((B - R) * T) * SpecialFunctions.Functions.N(-d1));
        }
        public double Price(double U)
        {

            if (Otyp == "1")
            {
                return CallPrice(U);
            }
            else
                return PutPrice(U);

        }

        #endregion Methods

    }
}
