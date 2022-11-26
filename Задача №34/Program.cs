// Задача №34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] CreatNewArray (int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
int[] array = CreatNewArray(size, 100, 999);

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

int EvenNumbers (int[] array)
{
    int num = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) num+= 1;
        else i++;
    }
    return num;
}
int sumnumber = EvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в масиве :{sumnumber}");