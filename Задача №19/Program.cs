// Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 10000)
{
    Console.WriteLine("Невозможно проверить, нехватает цифры");
}
void Palidrome (int num)
{
    if (num > 10000)
    {
        int num1 = num / 10000;
        int num2 = num % 10;
            if (num1==num2)
            {
                num = num / 10;
                int num3 = (num / 100) % 10;
                int num4 = num % 10;
                if (num3==num4)
                Console.WriteLine("Да");
            }
            else Console.WriteLine("Нет");
    }
    else Console.WriteLine("Нет");
}
Palidrome(number);