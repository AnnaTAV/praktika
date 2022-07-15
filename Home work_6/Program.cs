// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5;
// 78 -> третьей цифры нет;
// 32679 -> 6;

Console.WriteLine("Введите любую цифру: ");
// int num = new Random().Next(1,50000);
int num = Convert.ToInt32(Console.ReadLine()); 
string numbers = Convert.ToString(num);
if(numbers.Length > 2)
{
    Console.WriteLine($"{num} -> {numbers[2]}");
}
    else
    {
        Console.WriteLine ($"{num} -> Третьей цифры нет!");
    }

