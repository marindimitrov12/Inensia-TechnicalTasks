using System;
using System.Collections.Generic;

namespace Zad2
{
    class Program
    {/* To add more taxes you need to create an interfaces and a classes for them.
       Then add them to the TaxEnum ,TaxBuilder dictionary and taxesMethods in Main. */
        static void Main(string[] args)
        {
            double grossSalary = 0;
         
            Console.WriteLine("Enter Salary:");
            var input = Console.ReadLine();
            double.TryParse(input, out grossSalary);
          
            var taxesMethods = new List<TaxEnum>() { TaxEnum.Income, TaxEnum.SocialContribution };
            var netSalary = CalculateSalary(grossSalary, taxesMethods);
            Console.WriteLine(netSalary);
        }

        public static double CalculateSalary(double grossSalary, List<TaxEnum> taxes)
        {
            var factory = new TaxBuilder();
            double nonTaxableAmount = 1000;
            double netSalary = grossSalary;
            foreach (var tax in taxes)
            {
                if (netSalary > nonTaxableAmount)
                {
                    netSalary = factory.Create(tax).Apply(netSalary, nonTaxableAmount); 
                }
            }
            return netSalary;
        }
    }
}

