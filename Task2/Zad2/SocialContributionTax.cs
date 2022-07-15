using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
   public class SocialContributionTax:ISocialContributionTax
    {
        public double Apply(double amount, double nonTaxableAmount)
        {
            double amountToBeTaxed = amount - nonTaxableAmount;
            if (amount - nonTaxableAmount <= 3000)
            {         
                double salaryAfterTax = nonTaxableAmount + amountToBeTaxed * 0.85;
                return salaryAfterTax;
            }
            else
            {
                
                double amountAboveMax = amount - nonTaxableAmount - 3000;
                double taxAmountForSocCont = 3000 * 0.85;
                double salaryAfterTax = amountAboveMax + nonTaxableAmount + taxAmountForSocCont;
                return salaryAfterTax;
            }
        }
    }
}
