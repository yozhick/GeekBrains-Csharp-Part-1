    //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
    //Требуется подсчитать сумму всех нечётных положительных чисел.
    //Сами числа и сумму вывести на экран, используя tryParse.
    //Михайлов Дмитрий Викторович


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder numbers = new StringBuilder();
            int currentNumber;
            int sum = 0;

            do
            {
                currentNumber = SafeInputNumber("Введите число:");
                if (currentNumber > 0 && currentNumber % 2 == 1)
                {
                    sum += currentNumber;
                    numbers.AppendLine(currentNumber.ToString());
                }

            } while (currentNumber != 0);

            Console.Clear();
            Console.Write(numbers.ToString());
            Console.WriteLine($"Сумма нечётных положительных чисел: {sum}");

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
