// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int randomnumber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {randomnumber}");

int firtdigit = randomnumber / 10;
int seconddigit = randomnumber % 10;

if (firtdigit == seconddigit) Console.WriteLine("Оба числа равны: " + firtdigit);
else if (firtdigit > seconddigit)
{
    Console.WriteLine("Максимальное число: " + firtdigit);
}
else
{
    Console.WriteLine("Максимальное число: " + seconddigit);
}