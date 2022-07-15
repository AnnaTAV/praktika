// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Является ли выходным, день недели под номером: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if(weekday == 6 || weekday == 7 ) 
{
Console.WriteLine($"{weekday} -> это выходной день");
}
else if(weekday < 1 || weekday > 7)
{
    Console.WriteLine($"{weekday} -> Такого дня недели не существует. Введите цифру от 1 до 7!");
}
else
{
    Console.WriteLine($"{weekday} -> это будний день");
}


