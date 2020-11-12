/*
 
    Написать метод подсчета количества цифр числа.
 
 */

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = SafeInputNumber("Введите число: ");
            Console.WriteLine($"Количество цифр в числе: {DigitCount(number)}");

            Console.ReadKey();
        }

        static int DigitCount(int num)
        {
            int result = 0;

            do
            {
                result++;
                num /= 10;

            } while (num != 0);

            return result;
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
