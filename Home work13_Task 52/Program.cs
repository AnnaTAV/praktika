// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[n, m];
GetMatrix(numbers);
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double num = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        num = (num + numbers[i, j]);
    }
    num = num / n;
    Console.Write(Math.Round(num, 1) + "; ");
}
Console.WriteLine();
PrintMatrix(numbers);

void GetMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
    }
  }
}

void PrintMatrix (int[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == 0) Console.Write("[");
        int RoundedMatrix = matrix[i, j]; 
        if (j < matrix.GetLength(1) - 1) 
        {
            Console.Write($"{RoundedMatrix}  "); 
        }
        else Console.Write($"  {RoundedMatrix}]");
    }
    Console.WriteLine();
}
}

