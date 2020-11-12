//а) Дописать класс для работы с одномерным массивом. 
//   Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
//   Создать свойство Sum, которое возвращает сумму элементов массива,
//   метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений),
//   метод Multi, умножающий каждый элемент массива на определённое число,
//   свойство MaxCount, возвращающее количество максимальных элементов. 
//б)**Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
//е) ***Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
//      Михайлов Дмитрий Викторович


using System;
using System.Linq;
using Task3_b;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int multiplier = 2;
            var coolArray = new CoolArray(20);
            // Расскоментировать для демонстрации конструктора.
            //var coolArray = new CoolArray(20, 1, 1);
            var elementsCount = coolArray.CountElements();
            var inverseCoolArray = coolArray.Inverse();

            coolArray.Print();
            Console.WriteLine();

            Console.WriteLine($"Сумма элементов: {coolArray.Sum}");

            Console.WriteLine($"Максимальный элемент: {coolArray.Max}");

            Console.WriteLine($"Количество максимальных элементов: {coolArray.MaxCount}");
            Console.Write("Inverse: ");
            inverseCoolArray.Print();
            Console.WriteLine();

            coolArray.Multi(multiplier);
            Console.Write($"Multi ({multiplier}): ");
            coolArray.Print();
            Console.WriteLine();

            Console.WriteLine("Количество элементов:");
            foreach(var element in elementsCount.Keys.OrderBy(p => p))
            {
                Console.WriteLine($"{element} -\t{elementsCount[element]}");
            }

            Console.ReadKey();
        }
    }
}
