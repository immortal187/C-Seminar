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


// Считаем сумму
int sum = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        
        if (i == j)
        sum = sum + array[i, j];
    }

}

Console.WriteLine("Сумма элементов главной диагонали: ");
Console.Write(sum);