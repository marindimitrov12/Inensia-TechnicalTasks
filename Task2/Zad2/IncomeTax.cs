using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
    public class IncomeTax:IIncomeTax
    {
        public double Apply(double amount, double nonTaxableAmount)
        {
            double amountToBeTaxed = amount - nonTaxableAmount;
            double salaryAfterTax = amountToBeTaxed * 0.9 + nonTaxableAmount;

            return salaryAfterTax;
        }
    }
}
