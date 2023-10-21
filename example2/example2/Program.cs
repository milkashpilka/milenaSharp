using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string inputString = Console.ReadLine();
            string uniqueString = "";
            foreach (char c in inputString)
            {
                if (!uniqueString.Contains(c.ToString()))
                {
                    uniqueString += c;
                }
            }
            Console.WriteLine("Исходная строка с удаленными повторами: " + uniqueString);
            Console.ReadKey();
        }
    }
}
