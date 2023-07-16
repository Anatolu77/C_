// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8
// Сгенерировать случайное число 
// Записать каждую цифру в отдельную переменную
// Сравнить переменную и вывести наибольшую

int number = new Random().Next(10,100);
int firstdigit  = number / 10;
int seconddigit = number % 10;
int max = firstdigit;
if (max < seconddigit)
{
    max = seconddigit;
}
Console.WriteLine($"Максимальная цифра в числе {number} -> {max}");
