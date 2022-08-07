//0. Демонстрация решения
//Напишите программу, 
//1. принимает число и выдаёт его квадрат (число
//умноженное на само себя).
//Например:
//4 -> 16;
//-3 -> 9;
// -7 -> 49;

Console.Clear();
string str = "Hello";
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
//int num = 9;
int res = num * num;
Console.WriteLine($"Квадрат числа {num} = {res}");