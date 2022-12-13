// Задача №66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите первое натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

PrintSumElemets(number,  number2);

void PrintSumElemets(int number, int number2)
{
    Console.Write(SumElemets(number - 1, number2));
}

int SumElemets(int number, int number2)
{
    int sum = number;
    if (number == number2)
        return 0;
    else
    {
        number++;
        sum = number + SumElemets(number, number2);
        return sum;
    }
}
