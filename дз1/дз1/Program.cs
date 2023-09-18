using milka;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки А:");
        Console.Write("X: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты точки В:");
        Console.Write("X: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Y: ");
        double y2 = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Длина отрезка AB = {distance:F3}");
    }
}