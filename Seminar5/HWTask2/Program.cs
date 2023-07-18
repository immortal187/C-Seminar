// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());


int[] FillArray(int[] array)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
    
        array[i] = new Random().Next(100, 1000);
        Console.Write(" " + array[i]);
    }
    return array;
    
}




int[] array = new int[size];

FillArray(array);
Console.WriteLine("");

int sum = 0;
for (int i = 0; i < array.Length; i++)
    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }

Console.Write("Сумма чисел на нечетных позициях: " + sum);