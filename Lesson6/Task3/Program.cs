//Переделать программу Пример использования коллекций для решения следующих задач:
//а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
//в) отсортировать список по возрасту студента;
//г) *отсортировать список по курсу и возрасту студента;
//        Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task3
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    class Program
    {
        static int OrderByFirstName(Student st1, Student st2)         
        {
            return string.Compare(st1.firstName, st2.firstName);          
        }

        static int OrderByAge(Student st1, Student st2)
        {
            return st1.age.CompareTo(st2.age);
        }

        static int OrderByCourseThenByAge(Student st1, Student st2)
        {
            int courseComparison = st1.course.CompareTo(st2.course);
            return courseComparison == 0 ? st1.age.CompareTo(st2.age) : courseComparison;
        }

        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            Dictionary<int, int> quantityByCourses = new Dictionary<int, int>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    Student newStudent = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]);
                    students.Add(newStudent);

                    if (newStudent.age >= 18 && newStudent.age <= 20)
                    {
                        if (quantityByCourses.ContainsKey(newStudent.course))
                            quantityByCourses[newStudent.course]++;
                        else
                            quantityByCourses.Add(newStudent.course, 1);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape)
                        return;
                }
            }
            sr.Close();
            //students.Sort(new Comparison<Student>(OrderByFirstName));       // Сортируем по имени
            //students.Sort(new Comparison<Student>(OrderByAge));             // Сортируем по возрасту
            students.Sort(new Comparison<Student>(OrderByCourseThenByAge)); // Сортируем по курсу и возрасту
            Console.WriteLine("Всего студентов:" + students.Count);
            Console.WriteLine("Магистров:{0}", students.Count(p => p.course >= 5));
            Console.WriteLine("Бакалавров:{0}", students.Count(p => p.course < 5));
            Console.WriteLine($"Студентов на 5 и 6 курсах: {students.Count(p => p.course == 5 || p.course == 6)}");
            Console.WriteLine("Студенты 18-20 лет по курсам:");
            foreach (var course in quantityByCourses.Keys.OrderBy(p => p))
            {
                Console.WriteLine($"Курс: {course} - {quantityByCourses[course]} студентов");
            }
            foreach (var v in students)
                Console.WriteLine(v.firstName);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

}
