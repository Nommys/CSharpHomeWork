// Задача №25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree < 0)
{
    Console.WriteLine("Степень не должна быть отрицательной");
}
else
{ int DegreeNumber (int sum)
{
    for (int i = 1; i < degree; i++)
    {
        sum = sum * number;
    }
    return sum;
}
int result = DegreeNumber(number);
Console.WriteLine(result);
}
