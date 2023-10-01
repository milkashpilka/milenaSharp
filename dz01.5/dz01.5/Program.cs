string input = "Дана строка (со скобками), внутри которых текст";
int startIndex = input.IndexOf('(');
int endIndex = input.LastIndexOf(')');

if (startIndex != -1 && endIndex != -1 && startIndex < endIndex)
{
    string result = input.Substring(startIndex + 1, endIndex - startIndex - 1);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("В строке нет пары скобок.");
}
