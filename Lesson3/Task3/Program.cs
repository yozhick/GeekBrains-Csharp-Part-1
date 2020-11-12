    //*Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
    //    Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
    //* Добавить свойства типа int для доступа к числителю и знаменателю;
    //*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    //**Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
    //***Добавить упрощение дробей.
    //Михайлов Дмитрий Викторович

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rational1 = new RationalNumber(101, 200);
            RationalNumber rational2 = new RationalNumber(100, 301);

            Console.WriteLine($"{rational1} + {rational2} = {rational1 + rational2}");
            Console.WriteLine($"{rational2} - {rational1} = {rational2 - rational1}");
            Console.WriteLine($"{rational1} * {rational2} = {rational1 * rational2}");
            Console.WriteLine($"{rational1} / {rational2} = {rational1 / rational2}");

            Console.ReadKey();
        }
    }
}
