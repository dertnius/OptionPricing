using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptionType;

namespace OptionPricingAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator med = new Mediator();
            med.calculate();
           

        }
    }
}
