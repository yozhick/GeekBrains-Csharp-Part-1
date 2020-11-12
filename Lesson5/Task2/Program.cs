using System;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            string message =
@"Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
д) ***Создать метод, который производит частотный анализ текста.
    В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
    Здесь требуется использовать класс Dictionary.
        Михайлов Дмитрий Викторович";

            var matches = Message.Words(message, 5);
            
            foreach(var item in matches)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(Message.RemoveWords(message, 'а'));
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(Message.GetLongestWord(message));
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine(Message.GetLongestWords(message));
            Console.ReadKey();

            Console.Clear();
            var wordsCount = Message.FrequencyAnalysis(message, new string[] {"и", "в", "из", "с", "не", "В"});
            foreach(var wordCount in wordsCount)
            {
                Console.WriteLine($"{wordCount.Key} - {wordCount.Value}");
            }
            Console.ReadKey();
        }
    }
}
