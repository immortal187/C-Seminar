// [Возвращаемый тип] [Имя метода - глагол] ([Параметры метода])
// {
//        Код метода
// }

int GetSum(int a , int b)
{
    int sum = a + b;
    return sum;
}    

void PrintMessageToConsole(string message)
{
    Console.WriteLine(message);
}

//---------------------------------------------------------------------------------------------------

int mySum = GetSum(10, 3);
PrintMessageToConsole(mySum.ToString());