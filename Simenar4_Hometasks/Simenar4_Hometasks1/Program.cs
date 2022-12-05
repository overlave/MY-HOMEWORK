// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW
Console.Clear ();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int n(int a, int b)
{
int n = a;
    for (int i = 0; i + 1 < b; i++)
{
    a = a*n;  
}
    return a;
}
    if (b <= 0)
Console.WriteLine("Второе число должно быть натуральным");
    else
Console.WriteLine($"{a},{b} -> {n(a,b)}");