using System;

class Program
{
    static void Main()
    {
        // Введення року
        Console.WriteLine("Введіть рік:");
        int year = Convert.ToInt32(Console.ReadLine());

        // Знаходження символу тварини за східним календарем
        int startYear = 1924;  // Рік початку 60-річного циклу
        int animalIndex = (year - startYear) % 12;

        // Масив із назвами тварин
        string[] animals = { "Миша", "Корова", "Тигр", "Заєць", "Дракон", "Змія", "Кінь", "Коза", "Мавпа", "Півень", "Собака", "Свиня" };

        // Виведення результату
        Console.WriteLine($"Рік {year} за східним календарем символізує тварина: {animals[animalIndex]}");
    }
}


