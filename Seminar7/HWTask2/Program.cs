// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());


int [,] array = new int[m, n];

// Заполнение массива

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1,11);
    }
}

// Вывод массива в консоль

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();   
}


Console.Write("Введите позицию m: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите позицию n: ");
int b = int.Parse(Console.ReadLine());

if (a < m && b < n)
{
    Console.Write("На данной позиции значение - " + array[a, b]);
}
else
{
    Console.Write("Такого числа нет в массиве"); 
}