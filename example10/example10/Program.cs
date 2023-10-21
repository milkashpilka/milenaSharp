using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символы: ");
            string input = Console.ReadLine();
            bool valid = true;
            foreach (char c in input)
            {
                if (c < '0' || c > '7')
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
