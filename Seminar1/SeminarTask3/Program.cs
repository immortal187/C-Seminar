﻿Console.WriteLine("введите число");

int a;
a = int.Parse(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("понедельник");
    break;

    case 2: Console.WriteLine("вторник");
    break;

    case 3: Console.WriteLine("среда");
    break;

    case 4: Console.WriteLine("четверг");
    break;

    case 5: Console.WriteLine("пятница");
    break;

    case 6: Console.WriteLine("суббота");
    break;

    case 7: Console.WriteLine("воскресение");
    break;

    default: Console.WriteLine("нет такого дня");
    break;
}
