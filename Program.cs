﻿Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b && a > c)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
else if (b > a && b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(c);
}
