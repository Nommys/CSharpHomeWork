// Задача №56: Задайте прямоугольный двухмерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine("Задайте прямоуголый двухмерный массив минимум 4х4");
Console.WriteLine("Введите количество строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows < 4)
{
    Console.WriteLine("Неверно заданы парамерты");
}
else if ( columns < 4)
{
    Console.WriteLine("Неверно заданы парамерты");
}
else
{
int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
{
    int[,] matr = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = rnd.Next(min, max +1);
        }
    } return matr;
}
int[,] matrix = CreateMatrixRndInt (rows, columns, 1, 10);

void CreatNewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i,j], 2}|");
        }
        Console.WriteLine();
    }
}
CreatNewArray(matrix);

int MinSum(int[,] matrix)
{
    int min = default;
    int minSum = default;
    int sum = default;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < min)
        {
            min = sum;
            minSum = i;
        }
        sum = 0;
    }
    return minSum;
}
int lowMinSum = MinSum(matrix);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {lowMinSum} ");
}