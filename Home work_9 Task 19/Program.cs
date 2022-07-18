// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите значение: ");
string num = Console.ReadLine();
void PalindromeNumber(string num)
{
    if (num[0] == num[4] || num[1] == num[3])
    {
        Console.WriteLine($"Значение: {num} - является палиндромом.");
    }
    else Console.WriteLine($"Значение: {num} - не является палиндромом.");
}
if (num.Length == 5)
{
    PalindromeNumber(num);
}
else Console.WriteLine($"Введите правильное значение");