// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear ();

int SumNumbers(int firstNum, int secondNum)
{
    if (firstNum == secondNum)
    {
        return firstNum;
    }
    if (firstNum > secondNum)
    {
        return secondNum + SumNumbers(firstNum, secondNum + 1);
    }
    return firstNum + SumNumbers(firstNum + 1, secondNum);
}

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine(SumNumbers(firstNumber, secondNumber));