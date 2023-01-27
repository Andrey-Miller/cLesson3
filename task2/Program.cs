// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double[] InputPoint3D(string str)
{
    double[] point = new double[3];
    string text;
    newTry:
    Console.Write(str);
    text = Console.ReadLine();
    string[] split = text.Split(' ');
    for (int i = 0; i <= 2; i++)
    {
        if (!(double.TryParse(split[i], out point[i])) || split.Length !=3)
        {   
            System.Console.WriteLine("Введены некорректные данные, повторите ввод");
            goto newTry;
        }                     

    }
    return point;
}

double Distance3D(double[] point1, double[] point2)
{
    return Math.Sqrt((Math.Pow((point2[0]-point1[0]), 2)) + (Math.Pow((point2[1]-point1[1]), 2)) + (Math.Pow((point2[2]-point1[2]), 2)));
}

double[] pointA = new double[3];
pointA = InputPoint3D("Введи координаты точки А (3 числа через пробел): ");
double[] pointB = new double[3];
pointB = InputPoint3D("Введи координаты точки B (3 числа через пробел): ");
System.Console.WriteLine($"Расстояние между точками: {Distance3D(pointA, pointB)}");