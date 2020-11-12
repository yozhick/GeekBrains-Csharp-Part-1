//Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) **с использованием регулярных выражений.
//        Михайлов Дмитрий Викторович

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;            

            do
            {
                Console.WriteLine("Введите логин: ");
                login = Console.ReadLine();
                Console.WriteLine(CorrectLogin(login));
                Console.WriteLine(CorrectLoginRegex(login));

            } while (true);


        }

        static bool CorrectLogin(string login)
        {
            if (login.Length < 2 || login.Length > 10 || char.IsDigit(login.First()))
                return false;

            foreach(var symbol in login)
            {
                if ((symbol < 'A' || symbol > 'Z') && (symbol < 'a' || symbol > 'z') && !char.IsDigit(symbol))
                {
                    return false;
                }

            }

            return true;
        }

        static bool CorrectLoginRegex(string login)
        {
            string pattern = "^[A-Za-z][A-Za-z0-9]{1,9}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(login);
        }
    }
}
