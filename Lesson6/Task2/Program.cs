//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата. 
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//    Использовать массив (или список) делегатов, в котором хранятся различные функции.
//б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
//    Пусть она возвращает минимум через параметр (с использованием модификатора out). 
//        Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task2
{
    class Program
    {

        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static void SaveFunc(Func<double, double> function, string fileName, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(function(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            List<double> values = new List<double>();
            min = double.MaxValue;
            
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                double currentValue = bw.ReadDouble();
                values.Add(currentValue);

                if (currentValue < min)
                    min = currentValue;
            }

            bw.Close();
            fs.Close();
            return values.ToArray();
        }

        public static List<Func<double, double>> GetFunctions()
        {
            List<Func<double, double>> functions = new List<Func<double, double>>();
            functions.Add(Math.Sin);
            functions.Add(p => p * p);
            functions.Add(p => p * p * p);
            return functions;
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

        static void Main(string[] args)
        {
            int[] menuValues = { 1, 2, 3 };   
            string[] functionsStrings = { "f(x) = sin(x)", "f(x) = p^2", "f(x) = p^3" };
            var functions = GetFunctions();
            int userChoice;

            do
            {
                userChoice = (int)SafeInputNumber(
                    "Выберите функцию:\n" +
                     $"{menuValues[0]}: {functionsStrings[0]}\n" +
                     $"{menuValues[1]}: {functionsStrings[1]}\n" +
                     $"{menuValues[2]}: {functionsStrings[2]}");

            } while (!menuValues.Contains(userChoice));

            double startValue = SafeInputNumber("Введите начальное значение:");
            double endValue = SafeInputNumber("Введите конечное значение:");
            double step = SafeInputNumber("Введите шаг:");

            SaveFunc(functions[userChoice - 1], "data.bin", startValue, endValue, step);
            _ = Load("data.bin", out double min);
            Console.WriteLine("Минимальное значение функции на отрезке:");
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }

}
