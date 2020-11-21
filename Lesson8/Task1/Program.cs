//С помощью рефлексии выведите все свойства структуры DateTime
//        Михайлов Дмитрий Викторович

using System;

namespace Task1
{
    static class Program
    {

        static void Main()
        {
            var dateTimeType = typeof(DateTime);
            foreach(var info in dateTimeType.GetProperties())
            {
                Console.WriteLine($"{info.Name} ({info.PropertyType})");
            }

            Console.ReadKey();
        }
    }
}
