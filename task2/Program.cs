// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int getNumber(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int getMaxRankNumber(int number)
{
    // Ищем максимальный разряд числа
    int rankNumber = 10;
    while (true)
    {   
        int resultDiv = number / rankNumber;
        if (resultDiv < 10)
        {
            break;
        }
        rankNumber *= 10;
    }
    return rankNumber;
}

int getThreeNumber(int maxRankNumber, int number)
{
    
    return number / (maxRankNumber / 100) % 10;
}


int number = getNumber("Введите число => ");
int maxRank = getMaxRankNumber(number);
Console.WriteLine(maxRank);
Console.WriteLine(getThreeNumber(maxRank, number));

