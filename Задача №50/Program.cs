// Задача №50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
Console.Write("Введите строку:");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец:");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;
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

if (rows < 0 | rows > matrix.GetLength(0) - 1 | columns < 0 | columns > matrix.GetLength(1) - 1)
{
    Console.Write("Элемент не существует");
}
 else
{
    Console.Write("Значение элемента массива = {0}", matrix[rows, columns]);
}

