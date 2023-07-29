﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNat(int n)
{
    if (n == 0) {
        System.Console.WriteLine();
        return;
    }
    
    System.Console.Write(n + " ");
    PrintNat(n - 1);
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNat(n);