using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examaple5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя переменной: ");
            string inputString = Console.ReadLine();
            string answer = "YES";
            if (string.IsNullOrEmpty(inputString))
            {
                answer = "NO";
            }
            else
            {
                char firstChar = inputString[0];
                if (char.IsDigit(firstChar))
                {
                    answer = "NO";
                }
                string pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_";
                for (int i = 1; i < inputString.Length; i++)
                {
                    char currentChar = inputString[i];
                    if (pattern.IndexOf(currentChar) == -1)
                    {
                        answer = "NO";
                        break;
                    }
                }
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
