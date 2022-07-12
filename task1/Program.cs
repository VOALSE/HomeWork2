// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число ");
int one = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int two = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int three = Convert.ToInt32(Console.ReadLine());

int max = one;

if (two > max)
{
     max = two;
}
if (three > max)
{
    max = three;
}

Console.WriteLine($"Максимальное число {max}");