/*
    а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
    нужно ли человеку похудеть, набрать вес или всё в норме.
    б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    
    Михайлов Дмитрий Викторович
*/

using System;


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = SafeInputNumber("Введите свой рост в сантиметрах: ");
            var weight = SafeInputNumber("Введите свой вес в килограммах: ");

            BmiCalculator bmiCalculator = new BmiCalculator(weight, height);

            Console.WriteLine($"Ваш индекс массы тела {bmiCalculator.BodyMassIndex:F3} - {bmiCalculator}");
            Console.WriteLine($"Совет: {bmiCalculator.GetAdvice()}");

            Console.ReadKey();

        }

        public static double SafeInputNumber(string question)
        {
            while (true)
            {
                Console.WriteLine(question);
                if (double.TryParse(Console.ReadLine(), out double number))
                    return number;
                else
                    Console.WriteLine("Не удалось преобразовать введённые данные в число. Пожалуйста, повторите ещё раз.");
            }
        }
    }
}
