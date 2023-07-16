// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int ort1 = number1 % 7;
int ort2 = number1 % 23;
if ( ort1 == 0 && ort2 == 0)
{
    Console.WriteLine($"Число {number1}  кратно одновременно 7 и 23");
}
else 
{
    Console.WriteLine("Ошибка");
}
