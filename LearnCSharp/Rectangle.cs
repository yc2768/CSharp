using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    class Rectangle
    {
        private int width;
        private int height;
        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        }
        public int GetArea(out int cir)
        {
            cir = (width + height)*2;
           return width*height;
        }
    }
}
