// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i] = rnd.NextDouble()*100;
    }
    return arr;
}
void DiffMaxMin(double[] array)
{
    double maxNum = array[0];
    double minNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (minNum > array[i]) minNum = array[i];
        if (maxNum < array[i]) maxNum = array[i];
    }
    Console.WriteLine($"Максимальный элемент массива = {maxNum}");
    Console.WriteLine($"Минимальный элемент массива = {minNum}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива  = {maxNum - minNum}");  
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
}
double[] array = CreateArrayRndDouble (5, 0, 50);
PrintArray(array);
Console.WriteLine();
DiffMaxMin(array);
Console.WriteLine();