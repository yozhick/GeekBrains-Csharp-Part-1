//*Задача ЕГЭ.
//На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
//В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
//<Фамилия> <Имя> <оценки>,
//где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа,
//соответствующие оценкам по пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
//Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
//        Михайлов Дмитрий Викторович


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsLine =  "10\n" +
                                "Иванов Петр 4 3 4\n" +
                                "Петров Василий 4 5 3\n" +
                                "Сидорова Мария 4 5 4\n" +
                                "Сигал Стивен 4 3 3\n" +
                                "Шварценеггер Арнольд 3 5 4\n" +
                                "Петров Петр 4 5 3\n" +
                                "Петренко Дмитрий 4 5 4\n" +
                                "Сыроежкин Сергей 3 3 5\n" +
                                "Шариков Полиграф 3 3 4\n" +
                                "Преображенский Филипп 5 5 5";
            Student[] students;
            var studentLines = studentsLine.Split('\n');
            int studentCount = int.Parse(studentLines.First());
            students = new Student[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                var studentData = studentLines[i + 1].Split(' ');
                var newStudent = new Student(
                    studentData[1],
                    studentData[0],
                    new int[]
                        {
                         int.Parse(studentData[2]),
                         int.Parse(studentData[3]),
                         int.Parse(studentData[4])
                        }                        
                    );
                students[i] = newStudent;
            }

            double previousAvgMark = 0;
            int count = 0;

            Console.WriteLine("Худшие ученики: ");
            foreach(var student in students.OrderBy(p => p.AverageMark))
            {

                if (++count > 3 && previousAvgMark != student.AverageMark)
                    break;

                Console.WriteLine(student.ToString());
                previousAvgMark = student.AverageMark;
            }

            Console.ReadKey();

        }
    }
}
