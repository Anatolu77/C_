// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string CoordinateRange(int quarter)
{

    if (quarter == 1)

}

int GetInfo( string message)
{
    Console.Write(message);
    int numberQuarter = Convert.ToInt32(Console.ReadLine());
    return numberQuarter;
}



int quarter = GetInfo("Введите номер четверти: ");
Console.WriteLine($"Диапазон координат в четверти {CoordinateRange(numberQuarter)}");

