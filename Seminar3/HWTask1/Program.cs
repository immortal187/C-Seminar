// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetReverse(int num, int rev)
{
    while (num > 0) 
    { 
        rev = rev * 10 + num % 10; num /= 10; 
        
    }
    return rev;
}

void CheckNumber(int num)
{
    if (num == GetReverse(num, 0))
    {
        Console.WriteLine("Число - палиндром");
    }
    else
    {
        Console.WriteLine("Число - не палиндром");
    }
}


Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());


if (num > 9999 && num < 100000)
{
    CheckNumber(num);
}
else
{
    Console.WriteLine("Указанное число не пятизначное");
}