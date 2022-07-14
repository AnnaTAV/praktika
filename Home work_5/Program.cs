// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int num = new Random().Next(100,1000);
int result = RemoveSecond(num);
Console.WriteLine($"{num} -> {result}");

int RemoveSecond(int num)
{
    int first = num % 100;
    int second = num / 10;// int second = num * 10;
    return second % 10;// return first * 10 + third;
}