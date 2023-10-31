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
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double randomNumber = random.NextDouble();
                Console.WriteLine(randomNumber);
            }
            Console.ReadKey();
        }
    }
}
