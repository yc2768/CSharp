using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class SalesEmployee:Employee
    {
        private decimal salesbouns;
        public SalesEmployee(string name, decimal basepay,decimal salesbounds)
            : base(name, basepay)
        {
            this.salesbouns = salesbouns;
        }
        public override decimal CalPay()
        {
            return basepay+salesbouns;
        }
    }
}
