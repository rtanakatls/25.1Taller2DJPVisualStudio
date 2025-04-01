using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Classroom
{
    internal class Menu
    {
        private List<Student> students;

        public Menu()
        {
            students = new List<Student>();
        }

        public void Execute()
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce una opción:");
                Console.WriteLine("1. Añadir un nuevo alumno");
                Console.WriteLine("2. Mostrar todos los alumnos");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowStudents();
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

        private void ShowStudents()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.GetData());
            }
        }

        private string GetName()
        {
            string name;
            Console.WriteLine("Introduce el nombre");
            name= Console.ReadLine();
            return name;
        }

        private float GetGrade(int gradeNumber)
        {
            float grade = 0;
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine($"Introduce la nota {gradeNumber}");
                grade = float.Parse(Console.ReadLine());
                if (grade < 0 || grade > 20)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 20");

                }
                else
                {
                    continueFlag = false;
                }
            }
            return grade;
        }

        private Student GetStudent()
        {
            string name = GetName();
            float grade1 = GetGrade(1);
            float grade2 = GetGrade(2);
            float grade3 = GetGrade(3);
            return new Student(name, grade1, grade2, grade3);
        }

        private void AddStudent()
        {
            students.Add(GetStudent());
        }
    }
}
