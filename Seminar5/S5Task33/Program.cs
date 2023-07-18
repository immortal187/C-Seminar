// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool IsNumber(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
        
    }
    return false;

}
        

int[] array = new int[10];
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()); 
if (IsNumber(array, num) == true)
 {
    Console.WriteLine("Число имеется в массиве? - ДА");
 }
else 
{
    Console.WriteLine("Число имеется в массиве? - НЕТ");
}