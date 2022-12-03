/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) 

x = (b2-b1)/(k1-k2) */

Double b1 = ReadInt("Введите число b1: ");
Double k1 = ReadInt("Введите число k1: ");
Double b2 = ReadInt("Введите число b2: ");
Double k2 = ReadInt("Введите число k2: ");


if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются.");
}
 
 else
{
Double x = (b2 - b1) / (k1 - k2);
Double y = k1 * x + b1;
//Double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения равна: , {x} , {y} ");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


