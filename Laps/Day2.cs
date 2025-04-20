using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        #region Design a 3D Point Class (lap1 day1)
        D3point point1 = new D3point(5, 6, 7);
        D3point point2 = new D3point(4,5);
        Console.WriteLine("\nPoint1 in all cordinate\n");
        point1.display();
        Console.WriteLine("\nPoint2 in all cordinate\n");
        point2.display();
        D3point res = D3point.CalculateDistance(point1, point2);
        res.display();
        Console.WriteLine($"\nDistace between point1 to point2\n = {Math.Sqrt(res.X * res.X + res.Y * res.Y + res.Z * res.Z)}");
        #endregion

        #region Fraction

        Fraction frac1 = new Fraction(1, 2);
        Fraction frac2 = new Fraction(3);

        Fraction result = Fraction.Add(frac1, frac2);

        Console.Write("Result of addition: ");
        result.Display();
        #endregion
    }
}
#region Design a 3D Point Class (lap1 day1)
class D3point
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public D3point(float xx, float yy, float zz)
    {
        X = xx;
        Y = yy;
        Z = zz;
    }
    public D3point(float xx, float yy):this(xx,yy,0)
    {
    }
    public void display()
    {
        // Cartesian
        Console.WriteLine(" In Cartesian Coordinates:");
        Console.WriteLine($"X = {X}, Y = {Y}, Z = {Z}");

        // Cylindrical
        double rho = Math.Sqrt(X * X + Y * Y);
        double phiCyl = Math.Atan2(Y, X);

        Console.WriteLine("\n In Cylindrical Coordinates:");
        Console.WriteLine($"(rho) = {rho:F2}, (phi) = {phiCyl:F2} rad, Z = {Z}");

        // Spherical
        double r = Math.Sqrt(X * X + Y * Y + Z * Z);
        double theta = Math.Acos(Z / r);
        double phiSph = Math.Atan2(Y, X);

        Console.WriteLine("\n In Spherical Coordinates:");
        Console.WriteLine($"r = {r:F2}, (theta) = {theta:F2} rad,  (phi) = {phiSph:F2} rad");
    }
    public static D3point CalculateDistance(D3point point1, D3point point2)
    {
        float XX = point1.X - point2.X;
        float YY = point1.Y - point2.Y;
        float ZZ = point1.Z - point2.Z;
        return new D3point(XX,YY,ZZ);
    }
}

#endregion



#region Fraction
class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        Numerator = numerator;
        Denominator = denominator;
    }
    public Fraction(int numerator):this(numerator,10)
    {
    }

    public void Display()
    {
        Console.WriteLine($"{Numerator}/{Denominator}");
    }

    public static Fraction Add(Fraction f1, Fraction f2)
    {
        int commonDenominator = f1.Denominator * f2.Denominator;
        int newNumerator = f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator;

        return new Fraction(newNumerator, commonDenominator);
    }
}
#endregion