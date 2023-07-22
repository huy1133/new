using System;
using System.Collections.Generic;

public class Circle
{
    public int Radius { get; set; }
}

public class CircleComparator : IComparer<Circle>
{
    public int Compare(Circle x, Circle y)
    {
        // Implement logic to compare 'x' and 'y' circles based on a specific property,
        // for example, the radius.
        // Return a negative value if 'x' circle is smaller than 'y' circle,
        // a positive value if it's greater, and 0 if they are equal.

        return x.Radius.CompareTo(y.Radius);
    }
}

public class Program
{
    public static void Main()
    {
        Circle[] circles = new Circle[]
        {
            new Circle { Radius = 5 },
            new Circle { Radius = 3 },
            new Circle { Radius = 8 }
        };

        CircleComparator circleComparator = new CircleComparator();
        Array.Sort(circles, circleComparator);

        foreach (Circle circle in circles)
        {
            Console.WriteLine(circle.Radius);
        }
    }
}
