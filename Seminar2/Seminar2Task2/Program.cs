// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int randomnumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {randomnumber}");

int firtdigit = randomnumber / 100 ;
int lastdigit = randomnumber % 10;

Console.Write(firtdigit);
Console.Write(lastdigit);

