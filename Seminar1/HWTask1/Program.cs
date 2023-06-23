// Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int a, b;

Console.Write("Введите число 1: ");
a = int.Parse(Console.ReadLine());  

Console.Write("Введите число 2: ");
b = int.Parse(Console.ReadLine());  

if (a > b)
{
    Console.WriteLine("Максимальное число - " + a);
} 
else
{
    Console.WriteLine("Максимальное число - " + b);
}