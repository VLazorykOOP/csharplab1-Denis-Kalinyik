using System;

class Program
{
    // Функція для обчислення виразу
    static double CalculateExpression(double a, double b)
    {
        double result = 1.0 / (Math.Pow(a, 2) + a * b + 1) - 1.0 / (Math.Pow(b, 2) + a * b + 1);
        return result;
    }

    static void Main()
    {
        // Введення значень a та b
        Console.WriteLine("Введіть значення a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення b:");
        double b = Convert.ToDouble(Console.ReadLine());

        // Виклик функції та виведення результату
        double result = CalculateExpression(a, b);
        Console.WriteLine($"Значення виразу при a={a} і b={b} дорівнює: {result}");
    }
}


