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
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int randomIndex = random.Next(uppercaseChars.Length);
                char randomChar = uppercaseChars[randomIndex];
                Console.Write(randomChar);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
