using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            bool continueFlag=true;
            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}.");

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("Ya eres mayor de edad");
                    continueFlag = false;
                }
                else if (age >= 0)
                {
                    Console.WriteLine("Eres menor de edad");
                    continueFlag = false;
                }
                else
                {
                    Console.WriteLine("Tu edad está mal");
                }
            }


            
        }
    }
}
