// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double GetLength(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)) ;
}

//------------------------------------------------------------------

Console.Write("Введите координату x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите координату x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = double.Parse(Console.ReadLine());

Console.WriteLine ("Длина = " + GetLength(x1, y1, x2, y2));