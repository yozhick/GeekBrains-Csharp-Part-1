//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
//        Михайлов Дмитрий Викторович

using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = GetAccountsFile();
            var attemptsCounter = 2; // изменить значение на 3 для успешного входа
            var success = false;

            try
            {
                var accounts = GetAccounts(fileName);

                for (int i = 0; i < attemptsCounter; i++)
                {
                    Console.WriteLine($"Логин и пароль №{i + 1}:");
                    var login = accounts[i].Login;
                    var password = accounts[i].Password;
                    Console.WriteLine($"{login} {password}");

                    success = Login(login, password);

                    if (success)
                    {
                        Console.WriteLine("Успешный вход в систему.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неудачная попытка");
                        Console.WriteLine();
                    }
                }

                if (!success)
                    Console.WriteLine("Количество попыток для входа закончилось.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
              

            Console.ReadKey();
        }

        private static string GetAccountsFile()
        {
            var fileName = Path.GetRandomFileName();
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                streamWriter.WriteLine("login P@$$w0rd");
                streamWriter.WriteLine("root Geekrains");
                streamWriter.WriteLine("root GeekBrains");
            }
            return fileName;
        }

        private static Account[] GetAccounts(string fileName)
        {
            if (!File.Exists(fileName))
                throw new Exception("Файл с аккаунтами не обнаружен.");

            var accountLines = File.ReadAllLines(fileName);
            var accounts = new Account[accountLines.Length];

            for (int i = 0; i < accountLines.Length; i++)
            {
                var lineArguments = accountLines[i].Split(' ');
                var login = lineArguments[0];
                var password = lineArguments[1];

                accounts[i].Login = login;
                accounts[i].Password = password;
            }

            return accounts;
        }

        static bool Login(string login, string password) =>
             login == "root" && password == "GeekBrains";
    }
}
