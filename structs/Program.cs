
//Readonly դաշտեր struct-ում

// using System;

// struct Point
// {
//     public readonly int X;
//     public readonly int Y;

//     public Point(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"x = {X}, y = {Y})");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Point p = new Point(3, 7);
//         p.Display();

//         // p.X = 20;
//     }
// }


// readonly struct

// using System;

// readonly struct Vector
// {
//     public int X { get; }
//     public int Y { get; }

//     public Point(int x, int y)
//     {
//         X = x;
//         Y = y;
//     }

//     public void Display()
//     {
//         Console.WriteLine($"x = {X}, y = {Y})");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Point p = new Point(4, 5);
//         p.Display();

//         // p.X = 7;
//     }
// }


// Կոորդինատային համակարգ

// using System;

// public readonly struct Point3D
// {
//     public Point3D(double x1, double y1, double z1, double x2, double y2, double z2)
//     {
//         X1 = x1;
//         Y1 = y1;
//         Z1 = z1;
//         X2 = x2;
//         Y2 = y2;
//         Z2 = z2;
//     }

//     public double X1 { get; }
//     public double Y1 { get; }
//     public double Z1 { get; }
//     public double X2 { get; }
//     public double Y2 { get; }
//     public double Z2 { get; }

//     public double GetDistance()
//     {
//         return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2) + Math.Pow(Z2 - Z1, 2));
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Point3D points = new Point3D(1, 2, 3, 4, 5, 6);
//         Console.WriteLine($"Distance between points: {points.GetDistance():F2}");
//     }
// }

