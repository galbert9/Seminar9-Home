﻿// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Задайте натуральное число"); 
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Задайте натуральное число больше предыдущего"); 
int n = Convert.ToInt32 (Console.ReadLine());

int SumRec (int m, int n)
{
    if (m <= n) return m + SumRec(m+1,n);
    else return 0;
}
Console.WriteLine(SumRec(m,n));
