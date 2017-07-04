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
            TestOut();
            //TestRef();
            //UsePerson();

           // UseQuad();
        }

        private static void TestOut()
        {
            int Area;
            int Cir;
            Rectangle r = new Rectangle(2, 3);
            Area = r.GetArea(out Cir);
            Console.WriteLine("Area:{0},Cir:{1}", Area, Cir);
        }

        private static void TestRef()
        {
            int i = 1;
            int j = 2;
            Console.WriteLine("i:{0},j:{1}", i, j);
            Program.Swap(ref i, ref j);
            Console.WriteLine("i:{0},j:{1}", i, j);
        }


        private static void Swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
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
