using FigureAreaCalculator.BaseFigures;

namespace FigureAreaCalculator.Tests;

public class CalculatorTests
{
    [Fact]
    public void CalcutareArea_CircleWithRadiusThree_ReturnsTwentySevenPointNine()
    {
        //Arrange
        var calculator = new Calculator();
        var circle = new Circle(3.0);
        //Act
        var area = calculator.CalculateArea(circle);
        //Assert
        Assert.Equal(28.27, area);
    }

    [Theory]
    [InlineData(18,17,5,42.42)]
    [InlineData(14,5,10,17.60)]
    [InlineData(6,13,11,32.86)]
    public void CalculateArea_TriangleWithInlineParams_EqualToResultParameter(double firstLine, double secondLine, double thirdLine, double result)
    {
        //Arrange
        var calculator = new Calculator();
        var triangle = new Triangle(firstLine,secondLine,thirdLine);
        //Act
        var area = calculator.CalculateArea(triangle);
        //Assert
        Assert.Equal(result, area);
    }
}