// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int xa, int xb, int ya, int yb, int za, int zb)
{
    double xc = (xa-xb)*(xa-xb);
    double yc = (ya-yb)*(ya-yb);
    double zc = (za-zb)*(za-zb);
    double result = Math.Sqrt(xc+yc+zc);
    return  result;
}
double distance = Distance(x1, x2, y1, y2, z1, z2);
double disRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точке A и B равно {disRound}");