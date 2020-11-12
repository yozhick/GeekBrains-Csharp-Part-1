/*
    *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
    «Хорошим» называется число, которое делится на сумму своих цифр.
    Реализовать подсчёт времени выполнения программы, используя структуру DateTime.

    Михайлов Дмитрий Викторович
*/
using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startValue = 1;
            const int endValue = 1000000000;

            DateTime startTime = DateTime.Now;
            int count = 0;

            for (int i = startValue; i < endValue; i++)
            {
                if (GoodNumber(i))
                    count++;
            }

            DateTime endTime = DateTime.Now;

            Console.WriteLine($"Количество «хороших» чисел в диапазоне от {startValue} до {endValue} = {count}");
            Console.WriteLine($"Время выполнения программы: {endTime - startTime}");

            Console.ReadKey();
        }

        static bool GoodNumber(int number) => number % SumDigits(number) == 0;

        static int SumDigits(int number)
        {
            int sum = 0;

            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}
