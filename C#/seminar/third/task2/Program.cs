// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Lenght(int xA, int yA, int xB, int yB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return distance;
}


int GetInfo( string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}


int CoordinateA1 = GetInfo("Введите координатy x точки A:  ");
int CoordinateA2 = GetInfo("Введите координатy y точки A:  ");
int CoordinateB1 = GetInfo("Введите координатy x точки A:  ");
int CoordinateB2 = GetInfo("Введите координатy y точки A:  ");


Console.WriteLine($"Расстояние между двумя точками на плоскости равно {Lenght(CoordinateA1, CoordinateA2, CoordinateB1, CoordinateB2)}");
