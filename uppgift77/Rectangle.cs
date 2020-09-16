using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Rectangle : IShape
    {
        public Rectangle(int width, int height)
        {
        }
        public int Area()
        {
            int Area = width * height;
            return Area;
        }

        public int Circumferance()
        {
            int Circumferance = width * 2 + height * 2;
            return Circumferance;
        }
    }
}
