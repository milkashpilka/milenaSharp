using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символьную строку: ");
            string inputString = Console.ReadLine();
            string uniqueCharacters = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                char currentChar = inputString[i];
                if (uniqueCharacters.IndexOf(currentChar) == -1)
                {
                    uniqueCharacters += currentChar;
                }
            }
            int count = uniqueCharacters.Length;
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
