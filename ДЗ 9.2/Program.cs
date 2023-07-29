﻿// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumFromInterval(int m, int n)
{
    if (m == n) {
        return m;
    }
    
    return m + SumFromInterval(m + 1, n);
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n) {
    Console.WriteLine("Вы ошиблись, число M должно быть меньше числа N");
    return;
}

int sum = SumFromInterval(m, n);
Console.WriteLine("Сумма натуральных элементов в промежутке от " + m + " до " + n + " = " + sum);