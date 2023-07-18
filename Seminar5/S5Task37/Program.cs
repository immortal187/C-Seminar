// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


Console.Write("Укажите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] array = new int [size];


for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");

}


void GetIncrease(int[] array)
{

    int newsize; 
    if (array.Length % 2 == 0)
    {
        newsize = size / 2;
    }
    else
    {
        newsize = size / 2 + 1;
    }

    int [] mas = new int [newsize];
    Console.WriteLine();
    Console.Write("Новый Массив: ");
    for (int i = 0; i < newsize; i++)
    {
        mas[i] = array [i] * array[size - 1];
        Console.Write (mas[i] + " ");
        size = size - 1;
    }
   
}


   GetIncrease(array);