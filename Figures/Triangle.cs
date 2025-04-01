namespace Taller2DJP251.Figures
{
    internal class Triangle
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float GetArea()
        {
            return b * h / 2;
        }
    }
}
