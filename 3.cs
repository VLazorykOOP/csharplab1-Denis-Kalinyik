
using System;

class Program
{
    static void Main()
    {
        // Введення координат точки
        Console.WriteLine("Введіть координату x точки:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть координату y точки:");
        double y = Convert.ToDouble(Console.ReadLine());

        // Перевірка положення точки відносно заштрихованої області
        if ((x >= -23 && x <= 0) && (y >= -23 && y <= 0))
        {
            Console.WriteLine("Так");  // Точка лежить всередині заштрихованої області
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("На межі");  // Точка лежить на межі заштрихованої області
        }
        else
        {
            Console.WriteLine("Ні");  // Точка лежить поза заштрихованою областю
        }
    }
}



