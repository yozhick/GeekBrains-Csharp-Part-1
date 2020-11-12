/*
    С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    Михайлов Дмитрий Викторович
 */

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddNumbersSum = 0;
            int inputtedNumber;

            do
            {
                inputtedNumber = SafeInputNumber("Введите число:");

                if (inputtedNumber % 2 == 1)
                    oddNumbersSum += inputtedNumber;

            } while(inputtedNumber != 0);

            Console.WriteLine($"Сумма нечётных чисел: {oddNumbersSum}");

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
