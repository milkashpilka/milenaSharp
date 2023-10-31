using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "Дана строка, состоящая из нескольких слов";
            string[] words = inputString.Split(' ');

            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string randomWord = words[randomIndex];
            Console.WriteLine("Случайное слово: " + randomWord);
            Console.ReadKey();
        }
    }
}
