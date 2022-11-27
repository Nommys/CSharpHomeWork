// Задача №36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон чисел массива от: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте диапазон чисел массива до: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreatNewArray (int size, int min,int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] array = CreatNewArray(size, min, max);

void PrintArray (int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i < arr1.Length; i++)
    {
        if (i < arr1.Length - 1) Console.Write($"{arr1[i]}, ");
        else Console.Write($"{arr1[i]}");
    }
    Console.WriteLine("]");
}
PrintArray(array);

int SumDigit(int[] array)
{
    int sum = default;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum += array[i];
    } return sum;
}
int sumDigit = SumDigit(array);
Console.WriteLine($"Сумма числе стоящих на нечётных позициях :{sumDigit}");