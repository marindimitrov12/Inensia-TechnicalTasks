using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
   public interface ITax
    {        
      public double Apply(double amount, double nonTaxableAmount);
        
    }
}
