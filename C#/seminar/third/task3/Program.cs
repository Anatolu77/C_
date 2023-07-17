// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void DefSqr( int number)
{
    Console.Write($"{number} -> ");
    for (int i = 1; i < number; i++)
    {
        Console.Write(i * i + ",");
    }
    Console.WriteLine(number * number + ".");
}

int GetInfo( string message)
{
    Console.Write(message);
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    return inputNumber;
}


int number = GetInfo("Введите число: ");
DefSqr(number);
