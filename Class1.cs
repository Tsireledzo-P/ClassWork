using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
namespace Class1;

//Declaring an interface
public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

//Rectangle
class Rectangle : IShape
{
    private double length;
    private double width;

    //constructor 
    public Rectangle(double length, double width)
    {
        this.length = length;   
        this.width = width;
    }

    //implement methods
    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculatePerimeter()
    {
        return (2 * (length + width));
    }


}