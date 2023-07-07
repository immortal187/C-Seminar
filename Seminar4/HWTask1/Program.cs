// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int InputData(string message)
{
    Console.Write(message);
    int result= int.Parse(Console.ReadLine());
    return result;
}

int A = InputData("Введите число A: ");
int B = InputData("Введите число B: ");

double c = Math.Pow(A, B);

Console.WriteLine("Число A в степени B = " + c);