// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System.Globalization;
using System.Xml.XPath;

int getNumber(string msg)
{
    Console.WriteLine("Введите трехзначное число => ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

while (true)
{
    
    int number = getNumber("Введите трехзначное число => ");
    if (99 < number & number < 1000)
    {
        int secondDigit = number / 10 % 10;
        Console.WriteLine($"Вторая цифра в Вашем числе равна {secondDigit}");
        break;
    }
    else
    {
        Console.WriteLine("Ввели не правильное число");
    }
}
