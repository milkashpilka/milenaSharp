using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();
            int randomIndex = random.Next(lowercaseChars.Length);
            char randomChar = lowercaseChars[randomIndex];
            Console.WriteLine("Случайный символ в нижнем регистре: " + randomChar);
            Console.ReadKey();
        }
    }
}
