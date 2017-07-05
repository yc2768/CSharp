using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Person1
    {
        protected int age;
        protected string name;
        public Person1(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void  ShowPerson1Info()
        {
            Console.WriteLine("age:{0},name:{1}",age,name);
        }
    }
}
