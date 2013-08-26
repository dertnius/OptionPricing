using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionPricing;

namespace OptionType
{
    public struct Mediator
    {

        static IOptionFactory getFactory()
        {
            return new EuropeanOptionFactory();
        }
        public void calculate()
        {
            // 1. Choose how the data in the option will be created
            IOptionFactory fac = getFactory();
            // 2. Create the option, factory of options
            Option myOption = fac.create();
            // 3. Get the price
            Console.Write("Give the underlying price: ");
            double S = Convert.ToDouble(Console.ReadLine());
            // 4. Display the result
            Console.WriteLine("Price: {0}", myOption.Price(S));
        }


    }
}
