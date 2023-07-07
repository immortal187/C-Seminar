// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Request(string message)
{
    Console.Write(message);
    int result= int.Parse(Console.ReadLine());
    return result;
}

int Factorial(int number)
{
    
    int j = 1;

    for (int i = 1; i <= number; i++)
    {
        j = j * i;
    }
    return j;
}

int number = Request("Введите число: ");
Console.Write(Factorial(number));