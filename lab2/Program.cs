// See https://aka.ms/new-console-template for more information 
Console.WriteLine("Введите х");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y");
double y = double.Parse(Console.ReadLine());
if (y >= -1 && y <= 1 && x >= -1 && x <= 1 && x * x + y * y >= 1) Console.WriteLine(" верно");
else Console.WriteLine("НЕ верно");
