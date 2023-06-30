// Ввести число любой разрядности и вывести количество цифр в числе

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int counter = 0;  

while (a != 0)
{
    a = a / 10;
    counter++;
}

Console.WriteLine("Количество цифр в числе: " + counter);