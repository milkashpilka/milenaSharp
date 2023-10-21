using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символьную строку: ");
            string inputString = Console.ReadLine();
            string uniqueDigits = "";
            foreach (char c in inputString)
            {
                if (char.IsDigit(c))
                {
                    if (uniqueDigits.IndexOf(c) == -1)
                    {
                        uniqueDigits += c;
                    }
                }
            }
            if (!string.IsNullOrEmpty(uniqueDigits))
            {
                Console.WriteLine(uniqueDigits);
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
