//1. Напишите программу, которая на вход принимает два
//числа и проверяет, является ли первое число квадратом
//второго.
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет
//3. Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Clear();
string str = "Hello";
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2*num2--num1)
{
    Console.WriteLine("Первое число квадрат второго");
}
else
{
    Console.WriteLine("Первое число не квадрат второго");
}