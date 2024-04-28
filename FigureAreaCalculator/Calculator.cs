using FigureAreaCalculator.BaseFigures.Interfaces;

namespace FigureAreaCalculator;

public class Calculator
{
    public double CalculateArea(BaseFigure figure)
    {
        var result = figure.GetArea();
        return Math.Round(result,2, MidpointRounding.ToZero);
    }
}