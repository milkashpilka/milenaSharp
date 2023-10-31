using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Дана строка, состоящая из нескольких слов";
            inputString = inputString.Replace(" ", ""); // Удаление пробелов

            Random random = new Random();
            int randomIndex = random.Next(inputString.Length);
            char randomChar = inputString[randomIndex];
            Console.WriteLine("Случайный символ: " + randomChar);
            Console.ReadKey();
        }
    }
}
