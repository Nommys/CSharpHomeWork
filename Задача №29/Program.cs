// Задача №29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FindArray(int[] numberarray)
{
    Random rng = new Random();
    for (int index = 0; index < numberarray.Length; index++)
    {
        numberarray[index] = rng.Next (1, 100);
    }
}

void PrintArray (int[] numbers)
{
    for (int index = 0 ; index < numbers.Length; index++)
    {
        Console.Write($"{numbers[index]} ");
    }
}

FindArray(array);
PrintArray(array);