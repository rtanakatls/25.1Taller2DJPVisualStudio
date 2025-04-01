using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2DJP251.Figures;

namespace Taller2DJP251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FigureMenu menu = new FigureMenu();
            menu.Execute();

            /*
            float a;
            float b;

            Console.WriteLine("Introduce el primer número:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número:");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine($"La suma es: {a + b}");
            Console.WriteLine($"La resta es: {a - b}");
            Console.WriteLine($"La multiplicación es: {a * b}");
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir entre 0");
            }
            else
            {
                Console.WriteLine($"La división es: {a / b}");
                Console.WriteLine($"El módulo es: {a % b}");
            }
            */

            /*
            float days;

            Console.WriteLine("Introducir la cantidad de días");
            days = float.Parse(Console.ReadLine());

            Console.WriteLine($"En {days} días hay {days / 365} años");
            Console.WriteLine($"En {days} días hay {days / 7} semanas");
            */

            /*
            int year;

            Console.WriteLine("Introducir el año:");
            year=int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0 )
                    {
                        Console.WriteLine($"El año {year} es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"El año {year} no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine($"El año {year} es bisiesto");
                }
            }
            else
            {
                Console.WriteLine($"El año {year} no es bisiesto");
            }*/
            /*
            int a;

            Console.WriteLine("Introduce en número: ");
            a=int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a} es positivo");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} es negativo");
            }
            else
            {
                Console.WriteLine($"{a} es cero");
            }
            */
            /*
            int a;

            Console.WriteLine("Introduce el número");
            a=int.Parse(Console.ReadLine());
            if (a % 7 == 0 && a % 13 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 7 y 13");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 7");
            }
            else if (a % 13 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 13");
            }
            else
            {
                Console.WriteLine($"{a} no es divisible ni entre 7 ni entre 13");
            }
            */





        }


        
    }
}
