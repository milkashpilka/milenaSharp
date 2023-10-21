using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую символьную строку:");
            string inputString1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Введите вторую символьную строку:");
            string inputString2 = Console.ReadLine().ToUpper();
            string commonLetters = "";
            foreach (char c1 in inputString1)
            {
                if (inputString2.Contains(c1.ToString()))
                {
                    if (!commonLetters.Contains(c1.ToString()))
                    {
                        commonLetters += c1;
                    }
                }
            }
            if (!string.IsNullOrEmpty(commonLetters))
            {
                Console.WriteLine(commonLetters);
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadKey();
        }
    }
}
