// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.WriteLine("Введите номер день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) Console.WriteLine("Нет");
else if (day == 2) Console.Write("Нет");
else if (day == 3) Console.Write("Нет");
else if (day == 4) Console.Write("Нет");
else if (day == 5) Console.Write("Нет");
else if (day == 6) Console.Write("Да");
else if (day == 7) Console.Write("Да");
else Console.WriteLine("Такого дня не существует");