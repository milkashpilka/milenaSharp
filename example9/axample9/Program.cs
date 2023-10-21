using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axample9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            string inputString1 = Console.ReadLine().ToLower();
            Console.WriteLine("Введите вторую строку:");
            string inputString2 = Console.ReadLine().ToLower();
            string commonCharacters = "";
            for (int i = 0; i < inputString1.Length; i++)
            {
                char c = inputString1[i];
                if (inputString2.Contains(c.ToString()))
                {
                    if (!commonCharacters.Contains(c.ToString()))
                    {
                        commonCharacters += c;
                        int index1 = inputString1.IndexOf(c);
                        int index2 = inputString2.IndexOf(c);
                        Console.WriteLine($"{c} ({index1}, {index2})");
                    }
                }
            }
            if (string.IsNullOrEmpty(commonCharacters))
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
