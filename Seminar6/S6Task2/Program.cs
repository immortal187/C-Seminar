// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine()); 

Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine()); 

Console.Write("Введите число 3: ");
int c = int.Parse(Console.ReadLine()); 

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Треугольник может существовать!");
}
else
{
    Console.WriteLine("Треугольник не может существовать!");
}