using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAL.PremiumCalculatorEngine
{
    public class GenderRule : IPremiumRule
    {
       

        public double CalculatePremium(Customer customer)
        {
            if (customer.Gender == Gender.Male)
                return 1.2;
            else
                return 1.1;

        }
    }
}
