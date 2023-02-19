﻿// 60. Показать двумерный массив размером m×n заполненный целыми случайными числами

void FillArray(int[,] array)                                          
{
    for(int m=0; m<array.GetLength(0); m++)
    {
        for(int n=0; n<array.GetLength(1); n++)
        {
            array[m, n]=new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int m=0; m<array.GetLength(0); m++)
    {
        for(int n=0; n<array.GetLength(1); n++)
        {
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int m=5;
int n=4;

int[,] array=new int[m, n];

FillArray(array);
PrintArray(array);