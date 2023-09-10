
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите символ:");
        char symbol = Console.ReadKey().KeyChar;

        if (char.IsDigit(symbol) && symbol >= '0' && symbol <= '9')
        {
            Console.WriteLine("\n true");
        }
        else if (char.IsWhiteSpace(symbol))
        {
            Console.WriteLine("\n Это символ из категории пробельных");
        }
        else if (char.IsLower(symbol))
        {
            Console.WriteLine("\n Это символ из категории букв в нижнем регистре");
        }
        else if (char.IsUpper(symbol))
        {
            Console.WriteLine("\n Это символ из категории букв в верхнем регистре");
        }
        else if (char.IsPunctuation(symbol))
        {
            Console.WriteLine("\n Это символ из категории знаков препинания");
        }
        else if (char.IsControl(symbol))
        {
            Console.WriteLine("\n Это символ из категории управляющих символов");
        }
        else
        {
            Console.WriteLine("\n Это другой символ");
        }
    }
}
