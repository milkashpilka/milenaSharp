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
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double randomNumber = Math.Round(random.NextDouble() * 10 - 5, 3);
                Console.WriteLine(randomNumber);
            }
            Console.ReadKey();
        }
    }
}
