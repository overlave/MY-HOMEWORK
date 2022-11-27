Console.Clear ();

Console.WriteLine("Введите трехзначное число: ");

int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 100;
int n2 = (n - (n1 * 100))/10;

if (n < 100 || n > 999)
Console.WriteLine("Число не трехзначное");

else
Console.WriteLine(n2);