// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());


double[] FillArray(double[] array)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = Math.Round(rand.Next(-100, 100) + rand.NextDouble(), 2);
        Console.Write(" " + array[i]);
    }
    return array;
    
}

double[] array = new double[size];

FillArray(array);
Console.WriteLine("");

double max = array.Max();
double min = array.Min();

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

double sum = Math.Round(max - min, 2);
Console.WriteLine("Сумма максимального и минимального элементов = " + sum);