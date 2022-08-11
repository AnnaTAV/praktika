// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

void AmountNum(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Compare(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if(arr[i] > 0 ) count += 1; 
  }
  return count;
}

AmountNum(m);
Console.WriteLine($"Введено чисел больше 0: {Compare(array)} ");