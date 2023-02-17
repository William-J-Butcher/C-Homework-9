// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

void Sum(int m, int n)
{
    int count = 0;
    for (int i = m; i <= n; i++)
    {
       count += i;
    }
    Console.Write($"M = {m}; N = {n} -> {count}");
}

Sum(m,n);
