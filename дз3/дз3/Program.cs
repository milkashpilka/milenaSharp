namespace vyrazheniya
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения переменных:");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double v0 = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double v = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double R1 = double.Parse(Console.ReadLine());
            double R2 = double.Parse(Console.ReadLine());
            double m1 = double.Parse(Console.ReadLine());
            double m2 = double.Parse(Console.ReadLine());
            double r = double.Parse(Console.ReadLine());
            double I = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double R = double.Parse(Console.ReadLine());

            Console.WriteLine("А) " + Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2)));
            Console.WriteLine("Б) " + (x1 * x2 + x1 * x3 + x2 * x3));
            Console.WriteLine("В) " + (v0 * t + (a * Math.Pow(t, 2)) / 2));
            Console.WriteLine("Г) " + (m * Math.Pow(v, 2) / 2 + m * g * h));
            Console.WriteLine("Д) " + (1 / R1 + 1 / R2));
            Console.WriteLine("Е) " + (m * g * Math.Cos(a)));
            Console.WriteLine("Ж) " + (2 * Math.PI * r));
            Console.WriteLine("З) " + (Math.Pow(b, 2) - 4 * a * c));
            Console.WriteLine("И) " + (x1 * m1 * m2 / Math.Pow(r, 2)));
            Console.WriteLine("К) " + (Math.Pow(I, 2) * R));
            Console.WriteLine("Л) " + (a * b * Math.Sin(c)));
            Console.WriteLine("М) " + (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c))));
            Console.WriteLine("Н) " + ((a * x2 + b * c) / (a * x2)));
            Console.WriteLine("О) " + (Math.Sqrt(1 - Math.Pow(Math.Sin(x3), 2))));
            Console.WriteLine("П) " + (1 / Math.Sqrt(a * Math.Pow(x3, 2) + b * x3 + c)));
            Console.WriteLine("Р) " + ((Math.Sqrt(x3 + 1) + Math.Sqrt(x3 - 1)) / (2 * Math.Sqrt(x3))));
            Console.WriteLine("С) " + (Math.Abs(x3) + Math.Abs(x3 + 1)));
            Console.WriteLine("Т) " + (Math.Abs(1 - Math.Abs(x3))));
        }
    }
}