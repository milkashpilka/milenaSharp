using may;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;

        Console.WriteLine($"Теперь первое число равно {firstNumber}, а второе равно {secondNumber}");
    }
}