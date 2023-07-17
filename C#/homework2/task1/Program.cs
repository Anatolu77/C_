// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght(int xA, int yA, int zA, int xB, int yB, int zB)
{
    int deltax = xB - xA;
    int deltay = yB - yA;
    int deltaz = zB - zA;
    return Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
}

int GetInfo( string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}


int CoordinateA1 = GetInfo("Введите координатy x точки A:  ");
int CoordinateA2 = GetInfo("Введите координатy y точки A:  ");
int CoordinateA3 = GetInfo("Введите координатy z точки A:  ");
int CoordinateB1 = GetInfo("Введите координатy x точки B:  ");
int CoordinateB2 = GetInfo("Введите координатy y точки B:  ");
int CoordinateB3 = GetInfo("Введите координатy z точки B:  ");

Console.WriteLine($"Расстояние между тремя точками  равно {Lenght(CoordinateA1, CoordinateA2, CoordinateA3, CoordinateB1, CoordinateB2, CoordinateB3)}");
