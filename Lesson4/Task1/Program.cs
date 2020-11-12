//Дан целочисленный  массив  из 20 элементов.
//Элементы  массива  могут принимать  целые  значения  от –10 000 до 10 000 включительно.
//Заполнить случайными числами.
//Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.
//Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
//      Михайлов Дмитрий Викторович

using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range = 10_000;
            const int arrayLength = 20;
            int[] array = new int[arrayLength];

            Random random = new Random();

            Console.WriteLine("Дан массив: ");
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(-range, range);
                Console.Write($"{array[i]}; ");
            }

            Console.WriteLine();

            Console.WriteLine("Найденные пары, в которых только одно число делится на 3: ");
            int previousElement = array.First();
            int count = 0;
            for (int i = 1; i < arrayLength - 1; i++)
            {
                int currentElement = array[i];
                if (previousElement % 3 == 0 ^ currentElement % 3 == 0)
                {
                    Console.Write($"{previousElement} и {currentElement}; ");
                    previousElement = currentElement;
                    count++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Количество найденных пар: {count}");

            Console.ReadKey();


        }
    }
}
