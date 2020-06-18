using System;
using System.Collections.Generic;

abstract class Shape
{
    public virtual double Area { get { return 0; }}
}

class Circle : Shape
{
    private double r;
    public Circle(double radius) { r = radius; }
    public double Radius { get { return r; }}
    public override double Area { get { return Math.PI * r * r; }}
}

class ShapeAreaComparer : IComparer<Shape>
{
    int IComparer<Shape>.Compare(Shape a, Shape b)
    {
        if (a == null) return b == null ? 0 : -1;
        return b == null ? 1 : a.Area.CompareTo(b.Area);
    }
}

class Program
{
    static void Main()
    {
        // SortedSet<Circle> erwartet IComparer<Circle>. IComparer ist Contravariant
        // IComparer<Shape> zu übergeben ist also legal
        SortedSet<Circle> circlesByArea =
            new SortedSet<Circle>(
                // IComparer<Shape>
                new ShapeAreaComparer()) 
                // Beispielwerte
                { new Circle(7.2), new Circle(100), null, new Circle(.01) };
    }
}

/* This code example produces the following output:

null
Circle with area 0.000314159265358979
Circle with area 162.860163162095
Circle with area 31415.9265358979
 */
