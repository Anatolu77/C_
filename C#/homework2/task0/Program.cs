// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number,req,sum=0,t;
Console.Write("Введите пятизначное число: ");
number = Convert.ToInt32(Console.ReadLine());
if ( number > 9999 && number < 100000)
{
for ( t = number; number!=0; number = number / 10)
{
req = number % 10;
sum = sum * 10 + req;
}
if( t == sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число! ");
