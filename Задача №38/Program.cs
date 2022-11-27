// Задача №38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] CreatNewArray (int size)
{
    double[] arr1 = new double [size];
    for (int i = 0; i < arr1.Length; i++)
    {
        arr1[i] = Convert.ToDouble (new Random().Next(1,1000))/10 ;
    }
    return arr1;
}
double[] array = CreatNewArray(size);


void PrintArray (double[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < arr1.Length - 1) Console.Write($"{arr1[i]}, ");
        else Console.Write($"{arr1[i]} ");
    }
    Console.WriteLine("]");
}
PrintArray(array);

double MinMax (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    double result = max - min;
    return result;
}
double resultMinMax = MinMax(array) ;
double result = Math.Round(resultMinMax, 2, MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива : {result}");