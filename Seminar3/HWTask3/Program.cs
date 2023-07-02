//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void PrintQnumbers(int N)
{
    if (N < 1)
    {   
        Console.WriteLine("Введите число больше 0");
    }
    
    for (int i=1; i<= N; i++)
    {
        Console.Write(" " + Math.Pow (i, 3));
    }
   
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

Console.Write("Таблица кубов числел от 1 до N -->"); 
PrintQnumbers(N);