//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
Console.WriteLine($"Большее число: {numberA} ");
}
else if (numberA < numberB)
{
Console.WriteLine($"Меньшее число: {numberA} ");
}
if (numberA < numberB)
{
Console.WriteLine($"Большее число: {numberB} ");
}
else if (numberA > numberB)
{
Console.WriteLine($"Меньшее число: {numberB} ");
} 