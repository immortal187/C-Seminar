// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int InputData(string message)
{
    Console.Write(message);
    int result= int.Parse(Console.ReadLine());
    return result;
}

int SummDigits(int a)
{

   int sum = 0; 
   while (a > 0)
   {
        sum = sum + a % 10;
        a = a / 10; 
   }
   return sum; 

}


int a = Math.Abs(InputData("Введите число: "));
Console.WriteLine("Сумма цифр числа = " + SummDigits(a));