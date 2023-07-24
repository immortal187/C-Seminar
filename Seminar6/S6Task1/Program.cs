//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < array.Length / 2; i++) 
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];

    array[(array.Length - 1) - i] = temp;
}   

Console.WriteLine($"{String.Join(", ", array)}");   