// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


void GetAreaCoord(int x)
{
   
        switch (x)
        {
            case 1: Console.Write("x > 0, y > 0"); break;
            case 2: Console.Write("x > 0, y < 0"); break;
            case 3: Console.Write("x < 0, y < 0"); break;
            case 4: Console.Write("x < 0, y > 0"); break;

            default: Console.Write("Укажите номер плоскости от 1 до 4"); break;
        }
      
}


// ---------------------------------------------------------------------------------------------------------------
Console.Write("Введите номер плоскости: ");
int x = int.Parse(Console.ReadLine());

GetAreaCoord(x);