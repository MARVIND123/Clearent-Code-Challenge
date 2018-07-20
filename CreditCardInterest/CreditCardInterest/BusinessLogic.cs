using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCardInterest
{
    public class BusinessLogic
    {
        public float CalculateTotalInterest(IList<IPerson> persons)
        {
            float totalInterest = 0.0F;
            foreach (var person in persons)
            {
                totalInterest += person.CalculatePersonInterest();
            }

            return totalInterest;
        }
    }
}
