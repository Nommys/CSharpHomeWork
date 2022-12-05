// Задача №41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа через запятую: ");

int[] StringToNum(string integer)
{
    int count = 1;
    for (int i = 0; i < integer.Length; i++)
    {
        if (integer[i] == ',')
        {
            count++;
        }
    }
    int[] number= new int [count];
    int index = 0;
    for (int i = 0; i < integer.Length; i++)
    {
        string temp = "";

        while (integer [i] != ',')
        {
        if(i != integer.Length - 1)
        {
            temp += integer [i].ToString();
            i++;
        }
        else
        {
            temp += integer [i].ToString();
            break;
        }
        }
        number[index] = Convert.ToInt32(temp);
        index++;
    }
    return number;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

int[] numbers = StringToNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Значений больше 0 = {sum}");
