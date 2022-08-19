// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetMatrix(int m, int n)
{
    int[,]matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
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

int m = InputNumbers("Введите число строк 3-й матрицы: ");
int p = InputNumbers("Введите число столбцов 3-й матрицы: ");

Console.WriteLine($"Первая матрица:");
int[,] martrix1 = GetMatrix(2, 2);
PrintMatrix(martrix1);

Console.WriteLine($"Вторая матрица:");
int[,] martrix2 = GetMatrix(2, 2);
PrintMatrix(martrix2);

int[,] resultMatrix = new int[m,p];

MultMatrix(martrix1, martrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);

void MultMatrix(int[,] martrix1, int[,] martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix2[i,k] * martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
