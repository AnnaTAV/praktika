// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 int m = InputNumber("Введите значение M: ");
 int n = InputNumber("Введите значение N: ");
 int count = m;

int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }

 void SumNaturalNumber(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     SumNaturalNumber(m, n - 1, sum);

 }

 if (m > n)
 {
     m = n;
     n = count;
 }
 Console.Write($"{m}, {n} ->");
 SumNaturalNumber(m, n, count = 0);