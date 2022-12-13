// Задача №68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите первое неотрицательное  число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число:");
int number2 = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(number,number2);

void AkkermanFunction(int number, int number2)
{
    Console.Write(Akkerman(number, number2)); 
}

int Akkerman(int number, int number2)
{
    if (number == 0)
    {
        return number2 + 1;
    }
    else if (number2 == 0 && number > 0)
    {
        return Akkerman(number - 1, 1);
    }
    else
    {
        return (Akkerman(number - 1, Akkerman(number, number2 - 1)));
    }
}