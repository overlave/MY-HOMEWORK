// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear ();
Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
int count = 0;
int i = 1;

int OMG(int n)
{
while (i < 100000)                                
{                                                   
    count = n / i % 10 * 10000 / i;                  
    result = count + result;                           
    i = i * 10;                                          
}
return result;
}
if (N < 10000 || N > 99999)
Console.WriteLine("Число не пятизначное");
else
{
int res = OMG(N);
if (res == N)
Console.WriteLine($"{N} -> да");
else
Console.WriteLine($"{N}->нет");
}