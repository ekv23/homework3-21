//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84          
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Расстояние между точками — это число, равное корню 
//из суммы квадратов разностей координат точек или длине разности радиус-векторов точек.

double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
    double xDist = x2 - x1;
    double yDist = y2 - y1;
    double zDist = z2 - z1;

    return Math.Sqrt(Math.Pow(xDist, 2) + Math.Pow(yDist, 2) + Math.Pow(zDist, 2));
    }

double xA, yA, zA, xB, yB, zB;

Console.Write ("Координата точки А по оси х:  ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата точки А по оси y: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата точки А по оси z: ");
zA = Convert.ToDouble(Console.ReadLine());

Console.Write ("Координата точки B по оси х:  ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата точки B по оси y: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write ("Координата точки Z по оси z: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Расстояние между точками в 3D пространстве: " + Distance(xA, yA, zA, xB, yB, zB));