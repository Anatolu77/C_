﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void DefSqr( int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i < number; i++)
    {
        Console.Write(i * i * i + ",");
    }
    Console.WriteLine(number * number * number + ".");
}

int GetInfo( string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}


int number = GetInfo("Введите число: ");
DefSqr(number);