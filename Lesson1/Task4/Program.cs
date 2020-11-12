/*
    Написать программу обмена значениями двух переменных:
    а) с использованием третьей переменной;
    б) *без использования третьей переменной.
    
    Михайлов Дмитрий Викторович
 */


using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = int.MaxValue;
            int value2 = 5;

            Console.WriteLine($"{value1}\t{value2}");
            Swap<int>(ref value1, ref value2);
            Console.WriteLine($"1 swap: {value1}\t{value2}");
            SwapWithoutTempVariable(ref value1, ref value2);
            Console.WriteLine($"2 swap: {value1}\t{value2}");

            Console.ReadKey();
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void SwapWithoutTempVariable(ref int lhs, ref int rhs)
        {
            unchecked
            {
                lhs += rhs;
                rhs = lhs - rhs;
                lhs -= rhs;
            }
        }
    }
}
