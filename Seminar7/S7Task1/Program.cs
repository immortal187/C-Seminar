// Задайте двумерный массив размером m×n, заполненный случайными целыми числами

Console.Write("Введите количество строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());


int [,] array = new int[countRow, countColumn];

// Получение размерности массива
int arrayRowLength = array.GetLength(0);
int arrayColumnLength = array.GetLength(1); 

// Заполнение массива
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        array[i, j] = new Random().Next(1,11);
    }
}

// Вывод массива в консоль
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();   
}

// Вывод суммы элементов каждой строки
for (int i = 0; i < countRow; i++)
{
    int sum = 0;
    for (int j = 0; j < countColumn; j++)   
    {
        sum = sum + array[i, j];
    }

    Console.WriteLine($"В строке под номером [{i}] сумма элементов равна: {sum}");
}