// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

int size = int.Parse(Console.ReadLine());

// Заполнение массива

int [] array = new int [size];

for (int i = 0; i< array.Length; i++)
{
    array [i] = new Random().Next(1, 250);
    Console.Write(array[i] + " ");

}

Console.WriteLine();


// Считаем количество чисел
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}

Console.Write("Количество значений от 10 до 99: " + count);