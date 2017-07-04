using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadLibrary
{
    public class Quad
    {
        private double width = 0;
        private double height = 0;

        public  Quad(double w, double h)
        {
            width = w;
            height = h;
        }
        public double GetArea()
        {
            return width * height;
        }
    }
}
