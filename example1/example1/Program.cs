using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите символьную строку: ");
            string inputString = Console.ReadLine();
            string punctuationMarks = ".,;:!?";
            int punctuationCount = 0;
            foreach (char c in inputString)
            {
                if (punctuationMarks.Contains(c))
                {
                    punctuationCount++;
                }
            }
            Console.WriteLine("Количество знаков пунктуации: " + punctuationCount);
            Console.ReadKey();
        }
    }
}
