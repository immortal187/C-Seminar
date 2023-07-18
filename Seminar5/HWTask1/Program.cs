// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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

int count = 0;

for (int i = 0; i < array.Length; i++)
{
 
    if (array[i] % 2 == 0) 
    {
        count++;
    }
  
}


  Console.Write("Количество четных чисел: " + count);

