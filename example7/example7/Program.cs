using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символьную строку: ");
            string inputString = Console.ReadLine();
            string pattern = "0123456789";
            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                pattern = pattern.Replace(currentChar.ToString(), "");
            }
            if (!string.IsNullOrEmpty(pattern))
            {
                Console.WriteLine(pattern);
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
