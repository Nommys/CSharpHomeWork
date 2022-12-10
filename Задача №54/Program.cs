// Задача №54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());


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

Console.WriteLine("Массив до изменения:");
CreatNewArray(matrix);
SortArray(matrix);
void SortArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k +1]) 
                {
                    int temp = matrix[i, k+1];
                    matrix[i, k+1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
Console.WriteLine("Массив упорядочен по значениями:");
CreatNewArray(matrix);
