﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if((a>99 && a<1000) | (a>-999 && a<-99))
{
    int b = a/10 % 10;
    Console.Write("Вторая цифра числа: " + b);
    
}
else
{
    Console.WriteLine("Число не 3-значное.");
}