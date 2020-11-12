    //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    //Михайлов Дмитрий Викторович


using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Нажмите любую клавишу, чтобы продолжить...";

            StructDemonstartion();
            Console.WriteLine();
            Console.WriteLine(message);
            Console.ReadKey();
            Console.Clear();

            CLassDemonstration();
            Console.WriteLine(message);
            Console.ReadKey();
        }

        private static void CLassDemonstration()
        {
            ComplexClass complexNumber1 = new ComplexClass(
                SafeInputNumber("Введите действительную часть первого комплексного числа: "),
                SafeInputNumber("Введите мнимую часть первого комплексного числа: ")
                );
            ComplexClass complexNumber2 = new ComplexClass(
                SafeInputNumber("Введите действительную часть второго комплексного числа: "),
                SafeInputNumber("Введите мнимую часть второго комплексного числа: ")
                );

            Console.WriteLine("Введите символ операции: '+', '-' или '*':");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"({complexNumber2}) + ({complexNumber1}) = {complexNumber2.Plus(complexNumber1)}");
                    break;
                case "-":
                    Console.WriteLine($"({complexNumber2}) - ({complexNumber1}) = {complexNumber2.Minus(complexNumber1)}");
                    break;
                case "*":
                    Console.WriteLine($"({complexNumber2}) * ({complexNumber1}) = {complexNumber1.Multi(complexNumber2)}");
                    break;
                default:
                    Console.WriteLine("Неправильный символ.");
                    break;
            };
        }

        private static void StructDemonstartion()
        {
            Console.WriteLine("Демонстрация работы структуры:\n");

            ComplexStruct complexNumber1 = new ComplexStruct();
            complexNumber1.re = 2;
            complexNumber1.im = 1;

            ComplexStruct complexNumber2 = new ComplexStruct();
            complexNumber2.re = 1;
            complexNumber2.im = 2;

            Console.WriteLine($"({complexNumber2}) + ({complexNumber1}) = {complexNumber2.Plus(complexNumber1)}");
            Console.WriteLine($"({complexNumber2}) - ({complexNumber1}) = {complexNumber2.Minus(complexNumber1)}");
            Console.WriteLine($"({complexNumber2}) * ({complexNumber1}) = {complexNumber1.Multi(complexNumber2)}");
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
