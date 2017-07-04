using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadLibrary;
namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //UsePerson();

           // UseQuad();
        }

        private static void UsePerson()
        {
            Person p = new Person("CSharp", 60);
            p.ShowPersonInfo();
        }
        /// <summary>
        /// Quad调用
        /// </summary>
        private static void UseQuad()
        {
            Quad q = new Quad(10, 10);
            double area = q.GetArea();
            Console.WriteLine(area);
        }
    }
}
