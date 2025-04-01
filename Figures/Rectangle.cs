using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Figures
{
    internal class Rectangle
    {
        private float b;
        private float h;

        public Rectangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float GetArea()
        {
            return b * h;
        }
    }
}
