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
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int Number = rnd.Next(1,10);
                Console.WriteLine(Number);
            }
            Console.ReadKey();
        }
    }
}
