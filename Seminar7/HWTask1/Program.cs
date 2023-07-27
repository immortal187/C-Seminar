// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());


double [,] array = new double[m, n];

// Заполнение массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
       array[i, j] = new Random().NextDouble();
    }
}

// Вывод массива в консоль
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(Math.Round(array[i, j], 2) + " ");
    }
    Console.WriteLine();   
}