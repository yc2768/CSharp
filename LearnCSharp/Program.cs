using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadLibrary;
using System.Collections;
namespace LearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            //TestArrayListMethod();
            //TestArrayMethod();
            // TestAbstractMethod();
            // Testjicheng();
            //TestOut();
            //TestRef();
            //UsePerson();
           // UseQuad();
        }

        private static void TestArrayListMethod()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("ss");
            al.Remove(1);
            al.ToArray();
            al.Sort();
            al.Reverse();
        }

        private static void TestArrayMethod()
        {
            string[] StrArr = new string[2];
            int[,] IntArr = new int[2, 3];
            double[][] DoubleArr = new double[2][];
            DoubleArr[0] = new double[5];
            DoubleArr[1] = new double[3];
        }

        private static void TestAbstractMethod()
        {
            Student2 s2 = new Student2();
            Person2 p2 = s2;
            p2.Age = 12;
            p2.Name = "Tom";
        }

        private static void Testjicheng()
        {
            Student s = new Student(1, 12, "zs");
            s.ShowPerson1Info();
            s.ShowStudentInfo();
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
