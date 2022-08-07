// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int PositiveNumbers(int[] array)
{
    int numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            numbers++;
        }
    }
    return numbers;
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
int[] array = CreateArrayRndInd(4, 100, 1000);
PrintArray(array);
Console.WriteLine();
int numbers = PositiveNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве -> {numbers}");