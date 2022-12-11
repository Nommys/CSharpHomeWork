// Задача №58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] resultMatrix = new int[rows, columns];


int[,] CreateFirstMatrix (int rows, int columns, int min, int max)
{
    int[,] matr1 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i,j] = rnd.Next(min, max +1);
        }
    } return matr1;
}
int[,] firstMatrix = CreateFirstMatrix (rows, columns, 1, 10);

void PrintMatrix(int[,] firstMatrix)
{
    for (int i = 0; i < firstMatrix.GetLength(0);  i++) 
    {
        for (int j = 0; j < firstMatrix.GetLength(1);  j++) 
        {
            Console.Write($"|{firstMatrix[i,j], 2}|");
        }
        Console.WriteLine();
    }
}

int[,] CreateSecondMatrix (int rows, int columns, int min, int max)
{
    int[,] matr2 = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matr2.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            matr2[i,j] = rnd.Next(min, max +1);
        }
    } return matr2;
}
int[,] secondMatrix = CreateSecondMatrix (rows, columns, 1, 10);

Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);

void ResultMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    if (firstMartrix.GetLength(0) != secondMatrix.GetLength(1))
    {
    Console.WriteLine(" Нельзя перемножить ");
    return;
    } 
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
        int sum = 0;
        for (int k = 0; k < firstMartrix.GetLength(1); k++)
        {
            sum += firstMartrix[i,k] * secomdMartrix[k,j];
        }
        resultMatrix[i,j] = sum;
        }
    }
}
ResultMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine("Произведения двух матриц:");
PrintMatrix(resultMatrix);



