using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseobject
{
    class Triangle : IShape
    {
        public Triangle(int width, int height)
        {
        }
        public int Area()
        {
            int Area = height * width / 2;
            return Area;
        }

        public int Circumferance()
        {
            int Circumferance = height * 2 + width;
            return Circumferance;
        }
    }
}

