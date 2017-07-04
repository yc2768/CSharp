using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Person
    {
        public int ID;
        protected int age;
        private string name;
        public static int count;
        public Person(string name, int age)
        {
            this.name = name;
            this.age=age;
            count++;
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("Name:{0}\t Age:{1}", name, age);
        }
    }
}
