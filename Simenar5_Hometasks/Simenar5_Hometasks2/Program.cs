// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear ();
int [] CreateMassiv(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max) + 1;
    }
    return array;
}

void PrintMassiv(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, ");
        else
            Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int SummOddIndex(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i= i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}


int[] massiv = CreateMassiv(8, -10, 10);
PrintMassiv(massiv);
Console.WriteLine($" -> {SummOddIndex(massiv)}");
