using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Employee
    {
        public string name;
        protected decimal basepay;
        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }
        public virtual decimal CalPay()
        {
            return basepay;
        }
    }
}
