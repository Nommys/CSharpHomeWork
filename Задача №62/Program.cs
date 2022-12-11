// Задача №62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int rows = 4;
int[,] matrix = new int[rows, rows];

void CreateMatrixSpiral(int[,] matrix, int n)
{
    int i = 0, j = 0;
    int count = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { matrix[i, j++] = count++; } 
        while (++k < n - 1);
        for (k = 0; k < n - 1; k++) matrix[i++, j] = count++;
        for (k = 0; k < n - 1; k++) matrix[i, j--] = count++;
        for (k = 0; k < n - 1; k++) matrix[i--, j] = count++;
        ++i; 
        ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10)
            {
                Console.Write("0" + matrix[i, j]);
                Console.Write(" ");
            }
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
CreateMatrixSpiral(matrix, rows);
PrintMatrix(matrix);