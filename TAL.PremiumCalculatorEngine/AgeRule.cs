using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAL.PremiumCalculatorEngine
{

    
   public class AgeRule : IPremiumRule
    {


        public double CalculatePremium(Customer customer)
        {

            var customerAge = CalculateAge(customer.DateOfBirth);


            if (customerAge >=18 && customerAge <= 64)
                return 1;
            else
                return 0;

        }

        private int CalculateAge(DateTime dateOfBirth)
        {
            var age = DateTime.Now.Year - dateOfBirth.Year;

            if (DateTime.Now.Month < dateOfBirth.Month || (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day))
                age--;
            return age;
        }
    }
}
