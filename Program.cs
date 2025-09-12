using System;

class Program
{
    static void Main()
    {
        Console.Write("Введiть порядковий номер знака зодiаку (1-12): ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            string zodiac;

            switch (number)
            {
                case 1: zodiac = "Овен"; break;
                case 2: zodiac = "Тiлець"; break;
                case 3: zodiac = "Близнюки"; break;
                case 4: zodiac = "Рак"; break;
                case 5: zodiac = "Лев"; break;
                case 6: zodiac = "Дiва"; break;
                case 7: zodiac = "Терези"; break;
                case 8: zodiac = "Скорпiон"; break;
                case 9: zodiac = "Стрiлець"; break;
                case 10: zodiac = "Козорiг"; break;
                case 11: zodiac = "Водолiй"; break;
                case 12: zodiac = "Риби"; break;
                default:
                    Console.WriteLine("Помилка: номер має бути вiд 1 до 12.");
                    return;
            }

            Console.WriteLine($"Знак зодiаку: {zodiac}");
        }
        else
        {
            Console.WriteLine("Помилка: введено не число.");
        }

        Console.WriteLine("Натиснiть будь-яку клавішу для завершення...");
        Console.ReadKey();
    }
}
