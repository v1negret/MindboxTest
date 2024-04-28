using FigureAreaCalculator.BaseFigures.Interfaces;

namespace FigureAreaCalculator.BaseFigures;

public class Triangle : BaseFigure
{
    private double firstLine;
    private double secondLine;
    private double thirdLine;

    private Triangle()
    {
        
    }
    
    public Triangle(double first, double second, double third)
    {
        firstLine = first;
        secondLine = second;
        thirdLine = third;
    }
    public override double GetArea()
    {
        var p = (firstLine + secondLine + thirdLine) / 2;
        var S = Math.Sqrt(p*(p-firstLine)*(p-secondLine)*(p-thirdLine));

        return S;
    }

    public bool IsRectangular()
    {
        double a = Math.Min(firstLine, Math.Min(secondLine, thirdLine));
        double c = Math.Max(firstLine, Math.Max(secondLine, thirdLine));
        double b = firstLine + secondLine + thirdLine - a - c;
        
        return a * a + b * b == c * c;
    }
}