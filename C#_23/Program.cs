﻿/*Напишите программу, которая принимает
на вход число (N) и выдаёт таблицу кубов от 1 до N.
3 -> 1, 4, 9
5 -> 1, 8, 27, 64, 125*/

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int [] result = new int[N];
for (int i = 1; i <= N; i++)
    result[i - 1] = i * i * i;
for (int i = 0; i < N; i++)
    Console.Write($"{result[i]} ");
