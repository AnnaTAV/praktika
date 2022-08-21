// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29


int m = InputNumber("Введите значение M: ");
int n = InputNumber("Введите значение N: ");

int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}

int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int funAkkerman = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {funAkkerman} ");