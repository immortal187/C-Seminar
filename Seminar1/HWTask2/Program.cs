// Задача: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c, max;

Console.Write("Введите число 1: ");
a = int.Parse(Console.ReadLine());  

Console.Write("Введите число 2: ");
b = int.Parse(Console.ReadLine());  

Console.Write("Введите число 3: ");
c = int.Parse(Console.ReadLine());  

max = a;

if (max < b) max = b;
if (max < c) max = c;

Console.WriteLine("Максимальное число - " + max);