using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAL.PremiumCalculatorEngine
{
    public class PremiumCalculator : IPremiuimCalculatorEngine
    {
        List<IPremiumRule> _rules = new List<IPremiumRule>();

        public PremiumCalculator()
        {
            _rules.Add(new AgeRule());
            _rules.Add(new GenderRule());
        }

        public double CalculateCustomerPremium(Customer customer)
        {

            double Premiuim = 1;
            foreach (var rule in _rules)
            {
                Premiuim = rule.CalculatePremium(customer) * Premiuim;
            }

            return Math.Round(Premiuim * 100, 2);
        }
    }
}
