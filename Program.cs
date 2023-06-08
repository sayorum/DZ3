using System;
/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 100:");
        int number = ReadIntValue();

        if (number >= 1 && number <= 100)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 100.");
        }
    }

    static int ReadIntValue()
    {
        int value;
        bool isValid;

        do
        {
            isValid = int.TryParse(Console.ReadLine(), out value);

            if (!isValid || value < 1 || value > 100)
            {
                Console.WriteLine("Некорректное значение. Введите число от 1 до 100.");
                isValid = false;
            }

        } while (!isValid);

        return value;
    }
}
*/
// 2
/*
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double number1 = ReadDoubleValue();

        Console.WriteLine("Введите процент:");
        double percent = ReadDoubleValue();

        double result = CalculatePercentage(number1, percent);
        Console.WriteLine($"Результат: {result}");
    }

    static double ReadDoubleValue()
    {
        double value;
        bool isValid;

        do
        {
            isValid = double.TryParse(Console.ReadLine(), out value);

            if (!isValid)
            {
                Console.WriteLine("Некорректное значение. Введите число.");
                isValid = false;
            }

        } while (!isValid);

        return value;
    }

    static double CalculatePercentage(double number, double percent)
    {
        return number * percent / 100;
    }
}
*/
// 3 

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четыре цифры:");

        int digit1 = ReadDigit();
        int digit2 = ReadDigit();
        int digit3 = ReadDigit();
        int digit4 = ReadDigit();

        int number = CreateNumber(digit1, digit2, digit3, digit4);
        Console.WriteLine($"Число: {number}");
    }

    static int ReadDigit()
    {
        int digit;
        bool isValid;

        do
        {
            isValid = int.TryParse(Console.ReadLine(), out digit);

            if (!isValid || digit < 0 || digit > 9)
            {
                Console.WriteLine("Некорректное значение. Введите цифру от 0 до 9.");
                isValid = false;
            }

        } while (!isValid);

        return digit;
    }

    static int CreateNumber(int digit1, int digit2, int digit3, int digit4)
    {
        return digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
    }
}
