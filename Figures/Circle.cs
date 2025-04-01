using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Figures
{
    internal class Circle
    {
        private float pi = 3.14f;
        private float r;

        public Circle(float r)
        {
            this.r = r;
        }

        public float GetArea()
        {
            return pi * r * r;
        }
    }
}
