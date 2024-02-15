
using System;

class Program
{
    // Функція піднесення у квадрат різниці двох дійсних чисел
    static double SquareDifference(double a, double b)
    {
        double difference = a - b;
        double square = Math.Pow(difference, 2);
        return square;
    }

    static void Main()
    {
        // Введення двох дійсних чисел
        Console.WriteLine("Введіть перше дійсне число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге дійсне число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Виклик функції та виведення результату
        double result = SquareDifference(number1, number2);
        Console.WriteLine($"Квадрат різниці {number1} і {number2} дорівнює {result}");
    }
}


