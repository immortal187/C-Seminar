// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int promt(string message) // ввод числа с экрана
{
    Console.Write(message);
    string ReadInput = Console.ReadLine();
    int result = int.Parse(ReadInput);

    return result;
}

// Генерируем случайный массив

int[] GenerateArray(int Length, int minValue, int maxValue) 
{
    int[] array = new int[Length]; // Объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }

    return array;
}

// Выводим массив на экран

void PrintArray(int[] array)
{
    Console.Write("[");

    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + " ");
        
    }

    Console.Write(array[array.Length -1]);
    Console.Write("]");

}

int Length = promt("Длина массива: ");
int min = promt("Начальное значение диапазона: ");
int max = promt("Конечное значение диапазона: ");
int[] array = GenerateArray(Length, min, max);

PrintArray(array);