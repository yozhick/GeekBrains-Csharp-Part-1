/*
    Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    С помощью цикла do while ограничить ввод пароля тремя попытками.

    Михайлов Дмитрий Викторович
 */

using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemptsCounter = 3;
            bool success;

            do
            {
                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string password = Console.ReadLine();

                success = Login(login, password);
                attemptsCounter--;

                if (!success && attemptsCounter > 0)
                    Console.WriteLine("Неудачная попытка входа!");

            } while (!success && attemptsCounter > 0);

            if (success)
                Console.WriteLine("Успешная авторизация");
            else
                Console.WriteLine("Количество попыток закончилось!");

            Console.ReadKey();
        }

        static bool Login(string login, string password) =>
            login == "root" && password == "GeekBrains";
    }
}
