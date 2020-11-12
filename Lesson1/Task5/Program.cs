/*
    а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    б) *Сделать задание, только вывод организовать в центре экрана.
    в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

    Михайлов Дмитрий Викторович
*/

using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите город проживания: ");
            string city = Console.ReadLine();

            Person person = new Person(firstName, lastName, city);
            string personData = person.ToString();

            Print(personData, 55 - personData.Length / 2, 15);
            

            Console.ReadKey();
        }

        static void Print(string ms, int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }
}
