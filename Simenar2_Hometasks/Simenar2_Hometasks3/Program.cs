Console.Clear ();

Console.WriteLine("Введите день недели: ");
int data = Convert.ToInt32(Console.ReadLine());

if (data > 7)
Console.WriteLine("День недели не может быть больше 7");
else if (data > 5)
Console.WriteLine("Выходной");
else if (data > 0)
Console.WriteLine("Будний день");
else
Console.WriteLine("День недели не может быть меньше 1");

// если день болльше семи то  Console.WriteLine("День недели не может быть больше 7"); 

// если меьше семи то проверяем следующие условие больше 5 да перепроверяем первое if меньше 7 Console.WriteLine("Выходной");

//если меньше семи то проверяем следующие условие больше 5 нет больше 0 да Console.WriteLine("Будний день");

// //если меньше семи то проверяем следующие условие больше 5 нет больше 0 нет Console.WriteLine("День недели не может быть меньше 1");


