using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символьную строку: ");
            string input = Console.ReadLine();
            bool valid = true;
            foreach (char c in input)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f')))
                {
                    valid = false;
                    break;
                }
            }
            Console.WriteLine(valid ? "YES" : "NO");
            Console.ReadKey();
        }
    }
}
