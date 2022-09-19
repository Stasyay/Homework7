﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Ввод:
// 1
// 2
// Вывод:
// 4

Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}


void RealeseMatrix(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int m = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if (i == n - 1 && j == m - 1) Console.WriteLine(matrix[i, j]);
    }
}


int[,] matrix = new int[5, 5];
InputMatrix(matrix);
PrintMatrix(matrix);
RealeseMatrix(matrix);

