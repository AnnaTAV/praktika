// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

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

void OrderedArray(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1)-1; j++)
    {
      for (int f = 0; f < matrix.GetLength(1) - 1; f++)
      {
        if (matrix[i, f] > matrix[i, f + 1])
        {
          int num = 0;
          num = matrix[i, f];
          matrix[i, f] = matrix[i, f + 1];
          matrix[i, f + 1] = num;
        }
      }
    }
  }
}

Console.WriteLine("Двумерный массив до изменения:");
Console.WriteLine();
int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);

Console.WriteLine();

Console.WriteLine("Отсортированный массив:");
Console.WriteLine();
OrderedArray(matrix);
PrintMatrix(matrix);





