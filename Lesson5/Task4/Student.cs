using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student
    {
        public string Name { get; }
        public string LastName { get; }
        public readonly int[] Marks;
        public double AverageMark { get; private set; }

        public Student(string name, string lastName, int[] marks)
        {
            Name = name;
            LastName = lastName;
            Marks = marks;
            AverageMark = marks.Average();
        }

        public override string ToString()
        {
            return $"Фамилия: {LastName}, Имя: {Name}, Средний балл: {AverageMark}";
        }

    }
}
