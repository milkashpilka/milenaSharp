using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string digits = "0123456789";
            string specialCharacters = "!@#$%^&*()_+-=[]{}|;:'<>,.?/~";
            StringBuilder password = new StringBuilder();
            // Добавляем по одному символу из каждой категории
            password.Append(lowercaseChars[random.Next(lowercaseChars.Length)]);
            password.Append(uppercaseChars[random.Next(uppercaseChars.Length)]);
            password.Append(digits[random.Next(digits.Length)]);
            password.Append(specialCharacters[random.Next(specialCharacters.Length)]);
            // Дополняем пароль случайными символами
            for (int i = 4; i < random.Next(8, 16); i++) // Длина пароля от 8 до 15 символов
            {
                string allCharacters = lowercaseChars + uppercaseChars + digits + specialCharacters;
                password.Append(allCharacters[random.Next(allCharacters.Length)]);
            }
            Console.WriteLine("Сгенерированный пароль: " + password.ToString());
            Console.ReadKey();
        }
    }
}
