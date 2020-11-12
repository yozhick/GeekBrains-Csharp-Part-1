/*
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

Михайлов Дмитрий Викторович
 */

using System;
using System.Drawing;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = SafeInputNumber("Введите значение x первой точки: ");
            var y = SafeInputNumber("Введите значение y первой точки: ");
            Point point1 = new Point(x, y);

            x = SafeInputNumber("Введите значение x второй точки: ");
            y = SafeInputNumber("Введите значение y второй точки: ");
            Point point2 = new Point(x, y);

            var distance = CalculateDistance(point1, point2);
            Console.WriteLine($"Расстояние между точками: {distance:F2}");

            Console.ReadKey();

        }

        public static double CalculateDistance(Point point1, Point point2)
        {
            var distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            return Math.Abs(distance);
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
