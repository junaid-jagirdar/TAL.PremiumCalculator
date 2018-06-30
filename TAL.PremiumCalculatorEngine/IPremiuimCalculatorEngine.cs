using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL.PremiumCalculatorEngine;

namespace TAL.PremiumCalculatorEngine
{
    public interface IPremiuimCalculatorEngine
    {
        double CalculateCustomerPremium(Customer customer);
    }
}
