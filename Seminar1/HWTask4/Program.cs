﻿// Задача: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

int N, i;

Console.Write("Введите число: ");
N = int.Parse(Console.ReadLine());  

for (i=1; i<=N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}