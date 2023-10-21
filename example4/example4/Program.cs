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
                Console.Write("Введите символьную строку: ");
                string inputString = Console.ReadLine();
                string duplicateDigits = "";
                string processedDigits = "";
                foreach (char c in inputString)
                {
                    if (char.IsDigit(c))
                    {
                        if (processedDigits.Contains(c.ToString()))
                        {
                            if (!duplicateDigits.Contains(c.ToString()))
                            {
                                duplicateDigits += c;
                            }
                        }
                        else
                        {
                            processedDigits += c;
                        }
                    }
                }
                if (!string.IsNullOrEmpty(duplicateDigits))
                {
                    Console.WriteLine(duplicateDigits);
                }
                else
                {
                    Console.WriteLine("NO");
                }
            Console.ReadKey();
            }
    }
}
