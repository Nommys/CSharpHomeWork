// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите минимум трёхзначиное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int MaxDigit(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    } return num % 10;
}
int result = MaxDigit(number);
if (number < 100)
Console.WriteLine("Нет третьей цифры или оно отрицательное");
else Console.WriteLine(result);
