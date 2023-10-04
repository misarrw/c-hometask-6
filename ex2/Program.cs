// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void Function(double b01, double k01, double b02, double k02)
{
    double x = (b02-b01)/(k01-k02);
    double y = (k02*x)+b02;
    Console.Write("(" + x + "; " + y + ")");
}
int b1 = int.Parse(Console.ReadLine()!);
int k1 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);
int k2 = int.Parse(Console.ReadLine()!);
Function(b1, k1, b2, k2);