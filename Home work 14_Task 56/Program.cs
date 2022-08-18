// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n) // создание рандомного двумерного массива, заполнененного случайными числами
{
    int[,]matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array) // печатаем двумерный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
    {
        if (j == 0) Console.Write("[");
        if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3},");
        else Console.Write($"{array[i, j], 3}]");
    }
    Console.WriteLine();
}
}


void SumMinLineMatrix(int[,] array)
{
int minsum = Int32.MaxValue;
int minSumLine = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum < minsum)
    {
        minsum = sum;
        minSumLine = i;
    }
}
Console.WriteLine($"Cтрока с наименьшей суммой элементов находится под номером -> {minSumLine+1}.  Сумма элементов = {minsum}");
}


int[,] array = GetMatrix(4, 4);
PrintMatrix(array);

Console.WriteLine();

SumMinLineMatrix(array);




