﻿// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetDistance(X1, Y1, Z1, X2, Y2, Z2));
double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Round(Math.Sqrt(((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay)) + ((bz - az) * (bz - az))), 2, MidpointRounding.ToZero);
}
