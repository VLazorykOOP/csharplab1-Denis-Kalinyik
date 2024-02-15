using System;

class Program
{
    static void Main()
    {
        // Введення площі круга
        Console.WriteLine("Введіть площу круга:");
        double s = Convert.ToDouble(Console.ReadLine());

        // Обчислення радіуса кола за площею
        double radius = Math.Sqrt(s / Math.PI);


        // Виведення результату
        Console.WriteLine($"Радіус кола з площею {s} дорівнює: {radius}");
    }
}
