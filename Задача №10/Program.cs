// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int Multiplicity (int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}
int result = Multiplicity(number);
if (number < 100)
Console.WriteLine("Нет третьего числа");
else if  (number > 1000)
Console.WriteLine("Невозможно расчитать");
else Console.WriteLine(result);