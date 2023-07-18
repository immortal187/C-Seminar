// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] PrintArray(int[] array)
{
    Console.Write("Исходный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
    
        array[i] = new Random().Next(-10, 10);
        Console.Write(" " + array[i]);
    }
    return array;
    
}


int[] ChangeNum(int[] array)
{
    Console.Write("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] *= -1;
        Console.Write(" " + array[i]);
    }
    return array;
    
}
        

int[] array = new int[9];
PrintArray(array);
Console.WriteLine();
ChangeNum(array);
