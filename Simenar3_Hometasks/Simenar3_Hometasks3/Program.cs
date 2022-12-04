// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear ();
Console.WriteLine("Введите число");
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
void qube(int n)
{
    if (n > 0)
    {
        for (int i = 1; i <= n; i++)
        {
            double sqI = Math.Pow(i, 3);
            Console.WriteLine($"{i} | {sqI}");
        }
    }
    else
    {
        Console.WriteLine("Значение должно быть < 0");
    }
    }
Console.WriteLine($"{N} -> ");
qube(N);