//*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.
//      Михайлов Дмитрий Викторович

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слово: ");
            var line1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово: ");
            var line2 = Console.ReadLine();
            Console.WriteLine($"Слово {line1} { (IsReverseLines(line1, line2) ? string.Empty : "не ") }является перестановкой слова {line2}");
            Console.ReadKey();
        }

        static bool IsReverseLines(string line1, string line2)
        {
            var length = line1.Length;
            if (line2.Length != length)
                return false;

            for (int i = 0; i < length; i++)
            {
                if (line1[i] != line2[length - i - 1])
                    return false;
            }

            return true;
        }
    }
}
