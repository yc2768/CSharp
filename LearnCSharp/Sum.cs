using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    /// <summary>
    /// Test重载
    /// </summary>
    class Sum
    {
        public int AddOfNum(int x, int y)
        {
            return x + y;
        }
        public double AddOfNum(double x, double y)
        {
            return x + y;
        }
    }
}
