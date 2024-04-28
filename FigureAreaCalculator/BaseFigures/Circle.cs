using FigureAreaCalculator.BaseFigures.Interfaces;

namespace FigureAreaCalculator.BaseFigures;

public class Circle : BaseFigure
{
    private double radius;

    private Circle()
    {
        
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return (Math.Pow(radius, 2) * Math.PI);
    }
}