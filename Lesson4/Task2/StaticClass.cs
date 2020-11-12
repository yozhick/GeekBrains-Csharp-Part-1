using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    public static class StaticClass
    {
        public static void SolveTask1(int[] array)
        {
            int arrayLength = array.Length;

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
        }

        // Метод не обрабатывает исключения, т.к. они обрабатываются при вызове
        public static int[] GetArrayFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<int> numbers = new List<int>();
                while (!reader.EndOfStream)
                {
                    int number = int.Parse(reader.ReadLine());
                    numbers.Add(number);
                }
                return numbers.ToArray();
            }
            
        }
    }
}
