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

Console.Write("Исходный массив: ");
Console.WriteLine();

// Вывод массива в консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();   
}

for (int i = 0; i < m; i = i=i+2)
{
    for (int j = 0; j < n; j= j+2)
    {
        array[i, j] = array[i, j] * array[i, j];
    }
}

Console.Write("Новый массив: ");
Console.WriteLine();

// Вывод массива в консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();   
}