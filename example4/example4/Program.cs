using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int countNegatives = 0;
            double sumNegatives = 0;

            for (int i = 0; i < 20; i++)
            {
                double randomNumber = random.NextDouble() * 200 - 100;
                if (randomNumber < 0)
                {
                    countNegatives++;
                    sumNegatives += randomNumber;
                }
            }

            Console.WriteLine("Сумма отрицательных чисел: " + sumNegatives);
            Console.WriteLine("Количество отрицательных чисел: " + countNegatives);
            Console.ReadKey();
        }
    }
}
