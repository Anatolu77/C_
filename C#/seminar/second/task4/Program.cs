// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int resultsquare = number2 * number2;
if ( number1 == resultsquare)
{
    Console.WriteLine($"Первое число {number1} является квадратом второго числа {number2}");
}
else
{
    Console.WriteLine($"Первое число {number1} не квадрат второго {number2}");
}
