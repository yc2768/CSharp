using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Student2:Person2
    {
        public override void ShowInfo()
        {
            Console.WriteLine("age:{0},name:{1}",Age,Name);
        }
    }
}
