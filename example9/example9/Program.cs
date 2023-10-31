using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            string specialCharacters = "!@#$%^&*()_+-=[]{}|;:'<>,.?/~";
            for (int i = 0; i < 15; i++)
            {
                int randomIndex = random.Next(specialCharacters.Length);
                char randomChar = specialCharacters[randomIndex];
                Console.Write(randomChar);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
