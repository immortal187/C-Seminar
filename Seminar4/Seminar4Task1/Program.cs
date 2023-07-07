// Напишите программу которая принимает на вход А и выдает сумму от 1 до А

int GetSum(int limit)
{
    int sum = 1;

    for (int i = 1;i < limit; i++)
    {
        sum = sum + i;
    }

    return sum;
}

int sum = GetSum(4);
Console.WriteLine(sum);