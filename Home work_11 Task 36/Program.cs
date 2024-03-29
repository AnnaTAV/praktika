﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInd (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random ();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int SumPosElem(int[] array)
{
    int sumPos = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sumPos = sumPos + array[i];
    }
    return sumPos;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
int[] array = CreateArrayRndInd(4, 1, 100);
PrintArray(array);
Console.WriteLine();
int sumPos = SumPosElem(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumPos}");