//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите элементы для поиска максимума:\t");

int[] myarray = new int[3];

for (int i = 0; i < myarray.Length; i++)
{
    Console.WriteLine($"\nВведите {i+1} элемент:");
    myarray[i] = int.Parse(Console.ReadLine());
}


int maxValue = myarray.Max();
Console.WriteLine($"Максимальный элемент = {maxValue} ");

//подсказка
//Console.WriteLine($"число: {num1} ");