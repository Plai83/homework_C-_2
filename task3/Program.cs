// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


int getDigit(string msg)
{
    Console.WriteLine(msg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

while (true)
{
    int enterDigit = getDigit("Введите порядковый номер дня недели, цифра должна быть не от 1 до 7");
    if (0 <enterDigit & enterDigit < 8)
        {
        if (enterDigit == 6 & enterDigit == 7)
            {
                Console.WriteLine("Да, сегодня выходной");
            }
        else{
            Console.WriteLine("Нет, сегодня рабочий день");
        }
        }
        else 
        {
            Console.WriteLine($"Вы ввели не правильный день!");
        }
}
;
