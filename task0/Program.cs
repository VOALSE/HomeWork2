// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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