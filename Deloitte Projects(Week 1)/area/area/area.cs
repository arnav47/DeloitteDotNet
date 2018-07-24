using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area
{
    class area
    {
        int a;
        int b;
        float pi = 3.14f;
        float ar;
        float x, y;
        float r;

        public area()
        {

        }

        public float getArea(int a)
        {
            ar = a * a;
            return ar;
            
        }

        public float getArea(int a,int b)
        {
            ar = a * b;
            return ar;
        }

        public float getArea(float x, float y)
        {
            ar = (x * y) /2;
            return ar;
        }

        public float getArea(float r)
        {
            ar = pi * r * r;
            return ar;
        }
    }
}
