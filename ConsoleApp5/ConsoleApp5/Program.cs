using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (IsCharacter(input))
        {
            Console.WriteLine("Строка является символом.");
        }
        else if (IsInteger(input))
        {
            Console.WriteLine("Строка является целым числом.");
        }
        else if (IsDouble(input))
        {
            Console.WriteLine("Строка является дробным числом.");
        }
        else if (IsBoolean(input))
        {
            Console.WriteLine("Строка является логическим значением (true/false).");
        }
        else
        {
            Console.WriteLine("Строка не соответствует ни одному из проверенных типов.");
        }
    }

    static bool IsCharacter(string input)
    {
        char result;
        return char.TryParse(input, out result);
    }

    static bool IsInteger(string input)
    {
        int result;
        return int.TryParse(input, out result);
    }

    static bool IsDouble(string input)
    {
        double result;
        return double.TryParse(input, out result);
    }

    static bool IsBoolean(string input)
    {
        bool result;
        return bool.TryParse(input, out result);
    }
}