using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace Class1;

//circle
class Circle : IShape
{
    //new field
    private double radius;

    //constructor 
    public Rectangle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return 3.14 * radius^2;
    }

    public double CalculatePerimeter()
    {
        return 2 * 3.14 * radius;
    }
}