int a, b;

Console.Write("Введите число 1: ");

a = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");

b = int.Parse(Console.ReadLine());



Console.Write("Число 1 является квадратом числа 2?  -  ");

if (a == b * b)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}