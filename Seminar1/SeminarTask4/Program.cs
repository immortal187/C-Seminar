
int a;

Console.Write("Введите трехзначное число число: ");
a = int.Parse(Console.ReadLine());

if (a > 99 && a < 1000)
{
Console.WriteLine("Последняя цифра числа - " + a%10);
}
else
{
Console.WriteLine("Число не трехзначное");
}