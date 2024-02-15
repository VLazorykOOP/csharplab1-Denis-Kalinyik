using System;

class Program
{
    static void Main()
    {
        // Введення тризначного числа
        Console.WriteLine("Введіть тризначне число:");
        int number = Convert.ToInt32(Console.ReadLine());

        // Перевірка, чи введене число є тризначним
        if (number >= 100 && number <= 999)
        {
            // Виділення першої та другої цифри
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;

            // Порівняння першої та другої цифри
            if (firstDigit > secondDigit)
            {
                Console.WriteLine("Перша цифра більша за другу.");
            }
            else if (firstDigit < secondDigit)
            {
                Console.WriteLine("Друга цифра більша за першу.");
            }
            else
            {
                Console.WriteLine("Перша та друга цифри рівні.");
            }
        }
        else
        {
            Console.WriteLine("Введене число не є тризначним.");
        }
    }
}



