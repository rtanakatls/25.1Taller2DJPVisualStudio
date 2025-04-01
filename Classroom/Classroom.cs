using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DJP251.Classroom
{
    internal class Classroom
    {
        private List<Student> students;

        public Classroom()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);

        }

        public int GetPassedAmount()
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (student.GetAverage() >= 13)
                {
                    count++;
                }
            }
            return count;
        }


        public int GetFailedAmount()
        {
            return students.Count-GetPassedAmount();
        }

        public List<Student> GetPassedStudents()
        {
            List<Student> list = new List<Student>();   
            foreach (Student student in students)
            {
                if (student.GetAverage() >= 13)
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public List<Student> GetFailedStudents()
        {
            List<Student> list = new List<Student>();
            foreach (Student student in students)
            {
                if (student.GetAverage() < 13)
                {
                    list.Add(student);
                }
            }
            return list;
        }

        public float GetAverage()
        {
            float sum = 0;
            foreach(Student student in students)
            {
                sum += student.GetAverage();
            }

            return sum / students.Count;
        }
    }
}
