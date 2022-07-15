using System;
using System.Collections.Generic;
using System.Text;

namespace Zad2
{
   public class TaxBuilder
    {
        private Dictionary<TaxEnum, ITax> dic = new Dictionary<TaxEnum, ITax>() {
        {TaxEnum.Income, new IncomeTax{ } },
            {TaxEnum.SocialContribution, new SocialContributionTax{ } }
        };
        public ITax Create(TaxEnum type)
        {
            return dic[type];
        }
    }
}
