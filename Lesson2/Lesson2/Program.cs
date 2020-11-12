/*
    Написать метод, возвращающий минимальное из трёх чисел.

    Михайлов Дмитрий Викторович
*/

using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = SafeInputNumber("Введите число 1: ");
            int num2 = SafeInputNumber("Введите число 2: ");
            int num3 = SafeInputNumber("Введите число 3: ");

            Console.WriteLine($"Минимальное число: {Min(num1, num2, num3)}");

            Console.ReadKey();
        }

        static int Min(int num1, int num2, int num3)
        {
            if (num1 < num2)
            {
                return num1 < num3 ? num1 : num3;
            }
            else
            {
                return num2 < num3 ? num2 : num3;
            }
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
