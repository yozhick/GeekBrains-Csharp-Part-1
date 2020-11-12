/*  Условие:
        Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        а) используя склеивание;
        б) используя форматированный вывод;
        в) используя вывод со знаком $.

    ФИО:
        Михайлов Дмитрий Викторович */

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string queryPattern = "Пожалуйста, введите {0}:";
            Console.WriteLine(queryPattern, "своё имя"); // форматированный вывод
            string name = Console.ReadLine();

            Console.WriteLine(queryPattern, "свою фамилию"); // форматированный вывод
            string surname = Console.ReadLine();

            Person person = new Person();
            person.Name = surname + " " + name; // склеивание
            person.Age = SafeInputNumber("Сколько вам полных лет?");
            person.Height = SafeInputNumber("Какой у вас рост в сантиметрах?");
            person.Weight = SafeInputNumber("Сколько вы весите в килограммах?");
            Console.WriteLine();
            Console.WriteLine("Ваши данные:");
            Console.WriteLine(person.ToString()); // вывод со знаком $ в переопределении метода ToString() структуры Person

            Console.ReadKey();
        }

        public static int SafeInputNumber(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                if (int.TryParse(Console.ReadLine(), out int number))                
                    return number;                
                else                
                    Console.WriteLine("Не удалось преобразовать введённые данные в число. Пожалуйста, повторите ещё раз.");                
            }
        }
    }


}
