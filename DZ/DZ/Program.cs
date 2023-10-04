using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input1 = ":)";
        string input2 = ";---------[[[[[[[[";
        string input3 = ";--";
        string input4 = ":-)]";
        string input5 = "-)";
        string input6 = "::-(";
        string input7 = ":-()";

        Console.WriteLine(IsSmiley(input1)); // true
        Console.WriteLine(IsSmiley(input2)); // true
        Console.WriteLine(IsSmiley(input3)); // false
        Console.WriteLine(IsSmiley(input4)); // false
        Console.WriteLine(IsSmiley(input5)); // false
        Console.WriteLine(IsSmiley(input6)); // false
        Console.WriteLine(IsSmiley(input7)); // false
    }

    static bool IsSmiley(string input)
    {
        // Паттерн для смайликов
        string pattern = "^[;:](-*)[\\[\\]()]+$";

        // Проверка с помощью регулярного выражения
        return Regex.IsMatch(input, pattern);
    }
}