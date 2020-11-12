//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
//        Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public delegate double Fun(double a, double x);

    class Program
    {

        public static void Table(Fun F, double a, double x,  double maxValue)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= maxValue)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        static void Main()
        {
            double a = 1;

            Console.WriteLine("Таблица функции MyFunc:");
            Table(new Fun(MyFunc), a, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table((multiplier, x) => multiplier * Math.Sin(x), a, -2, 2);

            Console.ReadKey();
        }
    }

}
