﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear ();

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1-k2);
double y = k1 * x + b1;

    if (k1 == k2)
    Console.WriteLine("Прямые параллельны и не пересекаются ");

    else
    Console.WriteLine($"b1 = {b1}, {b2} = 2, k1 = {k1}, k2 = {k2} -> ({x} ; {y})");
