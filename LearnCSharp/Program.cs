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
            Quad q = new Quad(10, 10);
            double area = q.GetArea();
            Console.WriteLine(area);
        }
    }
}
