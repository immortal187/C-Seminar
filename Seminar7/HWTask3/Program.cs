// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

// Находим среднее арифметическое элементов каждого столбца
for (int i = 0; i < n; i++)
{
    double sum = 0;
    for (int j = 0; j < m; j++)   
    {
        sum = sum + array[j, i];
    }

    Console.WriteLine($"Среднее арифметическое элементов столбца [{i}]: {Math.Round(sum/m,2)}");
}