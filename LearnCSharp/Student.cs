using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Student:Person1
    {
        private int SID;
        public Student(int SID, int age, string name)
            : base(age, name)
        {
            this.SID = SID;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("SID:{0}",SID);
        }
    }
}
