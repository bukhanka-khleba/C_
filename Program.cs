using System;
using System.Text.RegularExpressions;

namespace LoginValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин для проверки:");
            string login = Console.ReadLine();
            
            bool isValid = IsLoginValid(login);
            Console.WriteLine($"Логин {(isValid ? "корректен" : "некорректен")}");
        }

        static bool IsLoginValid(string login)
        {
            if (string.IsNullOrEmpty(login))
                return false;

            // Регулярное выражение для проверки логина
            string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";
            Regex regex = new Regex(pattern);
            
            return regex.IsMatch(login) && login.Length >= 2 && login.Length <= 10;
        }
    }
}