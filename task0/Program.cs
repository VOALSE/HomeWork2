// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();

Console.Write("Введите первое число ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int two = Convert.ToInt32(Console.ReadLine());

if (one > two)
{
     Console.WriteLine($"Число {one}, больше {two}");
}
else {
    Console.WriteLine($"Число {two}, больше {one}");
}