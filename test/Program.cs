// Получение массива

double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i< array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble(), 2);
    }
    return array;
}

// Вывод массива на экран

void PrintDoubleArryToConsole(double[] array)
{
    string str = string.Join(' ', array);
    Console.WriteLine("Массив: " + str);
}

// ++++++++++++++++++++++++++++++

double[] array = GetRandomDoubleArray(size:10);
PrintDoubleArryToConsole(array);