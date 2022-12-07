// Задача №52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

void CreatNewArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
            Console.Write($"|{matrix[i,j], 2}|");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
CreatNewArray(matrix);


void SumMatrix (int[,] matrix)
{
    double sum = default;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        } 
        double avg = sum / 4;
        Console.Write($"{avg} ");
    }
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
SumMatrix(matrix);