// Задача №27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)number = -number;

int NumberLen (int num1)
{
    int index = 0;
    while (num1 > 0)
    {
        num1 = num1 / 10;
        index++;
    }return index;
}

int len = NumberLen(number);

int SumDigit (int num)
{
    int sum = default;
    for (int i = 0; i < len; i++)
   {
        sum = sum + num % 10;
        num = num / 10;
    }return sum;
}

int result = SumDigit(number);

Console.WriteLine(result);
