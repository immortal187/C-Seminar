//  Вывод числа в квардрате (число > 10)

int number;

// Исходное число
Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine());

// Проверка условия
if (number <= 10)
{
Console.WriteLine("Ваше число меньше 10-ти. Введите число больше 10-ти");
}
else
{

// Расчет квадрата числа
int result = number * number;
// Вывод результата
Console.Write($"Квадрат числа равен {result}");

}

Console.Write("Конец программы");
