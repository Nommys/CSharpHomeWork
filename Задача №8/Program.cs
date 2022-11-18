// Задача №8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for (int count = 1; count<= number; count++)
if (count <= number)
{
    if (count % 2 ==0)
    {
        Console.Write(count+" ");
    }
}
