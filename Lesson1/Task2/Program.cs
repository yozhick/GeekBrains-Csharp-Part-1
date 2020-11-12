/*      
Ввести вес и рост человека. 
Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h);   
где m — масса тела в килограммах, h — рост в метрах. 

Михайлов Дмитрий Викторович
*/

using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = SafeInputNumber("Введите свой вес в килограммах: ");
            var height = SafeInputNumber("Введите свой рост в сантиметрах: ");

            Person person = new Person(weight, height);
            var bmi = person.GetBodyMassIndex();

            Console.WriteLine($"Ваш индекс массы тела: {bmi}");

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
