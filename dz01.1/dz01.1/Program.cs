using System;

class Program
{
    static void Main()
    {
        string str = "С# обладает эффективными средствами обработки строк";
        int firstIndexOfO = str.IndexOf('о');
        Console.WriteLine($"Индекс первого вхождения символа 'о': {firstIndexOfO}");
        int lastIndexOfO = str.LastIndexOf('о');
        Console.WriteLine($"Индекс последнего вхождения символа 'о': {lastIndexOfO}");
        int firstIndexOfSubstring = str.IndexOf("ми");
        Console.WriteLine($"Индекс первого вхождения подстроки \"ми\": {firstIndexOfSubstring}");
        int lastIndexOfSubstring = str.LastIndexOf("ми");
        Console.WriteLine($"Индекс последнего вхождения подстроки \"ми\": {lastIndexOfSubstring}");
        int firstIndexOfMultipleChars = str.IndexOfAny(new char[] { 'а', '6', 'в' });
        Console.WriteLine($"Индекс первого вхождения символов 'а', '6' или 'в': {firstIndexOfMultipleChars}");
        bool startsWithSubstring = str.StartsWith("С# обладает");
        bool endsWithSubstring = str.EndsWith("строк");
        Console.WriteLine($"Строка str начинается с подстроки \"С# обладает\": {startsWithSubstring}");
        Console.WriteLine($"Строка str оканчивается подстрокой \"строк\": {endsWithSubstring}");
    }
}
