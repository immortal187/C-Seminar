// Указать, в какой плоскости находится точка (x, y)

int GetAreaNumber(int x, int y)
{
    int numberArea = 0;

    if (x > 0 && y > 0) numberArea = 1;
    if (x < 0 && y > 0) numberArea = 2;
    if (x < 0 && y < 0) numberArea = 3;
    if (x > 0 && y < 0) numberArea = 4;
    
    return numberArea;
}


// ------------------------------------------------------------------

Console.WriteLine("Начало работы программы.");

Console.Write("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату X: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Введены неверные координаты");
}
else
{
    int result = GetAreaNumber(x, y);
    Console.WriteLine("Номер четверти Вашей точки: " + result);
}