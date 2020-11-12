/*
    a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
    б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

    Михайлов Дмитрий Викторович
*/

using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = SafeInputNumber("Введите число а: ");
            int b = SafeInputNumber("Введите число b: ");
            Console.Clear();
            WriteNumbers(a, b);
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");

            Console.ReadKey();

            Console.WriteLine($"Сумма от {a} до {b} = {AmountFromTo(a, b)}");

            Console.ReadKey();
        }

        static void WriteNumbers(int from, int to)
        {
            if (from <= to)
            {
                Console.WriteLine(from);
                WriteNumbers(++from, to);
            }
        }

        static int AmountFromTo(int from, int to)
        {
            if (from == to)
                return from;

            if (from > to)
                return 0;

            return from + to + AmountFromTo(from + 1, to - 1);
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
