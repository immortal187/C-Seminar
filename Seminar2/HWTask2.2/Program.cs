Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100 && a > -100)
{
    Console.Write("Третьего числа нет");
}
else
{
    while (a > 999 || a < -999)
    {
        a = a / 10;
    }

   Console.Write("Третья цифра числа: " + Math.Abs(a%10)); 
}