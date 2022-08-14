// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int m = 3;
int n = 4;
double[,] matrix = new double[m, n];
void GetMatrix(double[,] matrix)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      matrix[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void PrintMatrix (double[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == 0) Console.Write("[");
        double RoundedMatrix = Math.Round(matrix[i, j], 1); 
        if (j < matrix.GetLength(1) - 1) 
        {
            Console.Write($"{RoundedMatrix}  "); 
        }
        else Console.Write($"  {RoundedMatrix}]");
    }
    Console.WriteLine();
}
}
GetMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();