using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Figures
{
    internal class FigureMenu
    {
        public void Execute()
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción");
                Console.WriteLine("1. Calcular el área del rectángulo");
                Console.WriteLine("2. Calcular el área del círculo");
                Console.WriteLine("3. Calcular el área del triángulo");
                Console.WriteLine("0. Salir");

                string option=Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CalculateRectangleArea();
                        break;
                    case "2":
                        CalculateCircleArea();
                        break;
                    case "3":
                        CalculateTriangleArea();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void CalculateRectangleArea()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la altura:");
            h=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la base:");
            b = float.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(b, h);
            Console.WriteLine($"El área es: {r.GetArea()}");
        }

        private void CalculateCircleArea()
        {
            float r;

            Console.WriteLine("Introduce el radio:");
            r = float.Parse(Console.ReadLine()); 

            Circle c = new Circle(r);
            Console.WriteLine($"El área es: {c.GetArea()}");
        }

        private void CalculateTriangleArea()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la altura:");
            h = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la base:");
            b = float.Parse(Console.ReadLine());

            Triangle t = new Triangle(b, h);
            Console.WriteLine($"El área es: {t.GetArea()}");

        }
    }
}
