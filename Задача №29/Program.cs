// Задача №29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] array = new int[8];

void FindArray(int[] numberarray)
{
    int lenght = numberarray.Length;
    int index = 0;
    while(index < lenght)
    {
        numberarray[index] = new Random().Next (1, 100);
        index++;
    }
}

void PrintArray (int[] numbers)
{
    int count = numbers.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{numbers[index]} ");
        index++;
    }
}

FindArray(array);
PrintArray(array);