// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());

if(a*a == b || b*b == a)  
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}