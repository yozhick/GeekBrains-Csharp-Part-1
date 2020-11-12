//Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
//б) *Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
//в)**Добавьте обработку ситуации отсутствия файла на диске.
//      Михайлов Дмитрий Викторович

using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range = 10_000;
            const int arrayLength = 20;
            string path = Path.GetTempFileName();

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                Random random = new Random();

                for (int i = 0; i < arrayLength; i++)
                {
                    streamWriter.WriteLine(random.Next(-range, range));
                }
            }

            try
            {
                var array = StaticClass.GetArrayFromFile(path);
                StaticClass.SolveTask1(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка чтения файла: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
