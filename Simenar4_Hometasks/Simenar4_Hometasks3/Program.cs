// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear ();
Console.WriteLine("Введите восемь элементов и я создам из них массив");
int[] myArray = new int[8];
for (int i = 0; i < myArray.Length; i++)
{
  Console.Write($"Введите элемент массива : ");
  myArray[i] = int.Parse(Console.ReadLine());
 }
  Console.WriteLine("А вот и наш массив:");
  for (int i = 0; i< myArray.Length; i++)
 {
   Console.WriteLine(myArray[i]);
 }
   Console.ReadLine();
