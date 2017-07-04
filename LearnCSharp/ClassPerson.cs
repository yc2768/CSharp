using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class ClassPerson
    {
        private int age;
        private string name;
        //无参数构造函数
        public ClassPerson() 
        {
            this.age = 18;
            this.name = "xiaoming";
        }
        //有参数
        public ClassPerson(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public int Age
        {
            get { return age; }
            set { this.age = age; }
        }
        public string  Name
        {
            get { return name; }
            set { this.name = name; }
        }

    }
}
