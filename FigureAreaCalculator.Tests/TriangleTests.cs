using FigureAreaCalculator.BaseFigures;

namespace FigureAreaCalculator.Tests;

public class TriangleTests
{
    [Fact]
    public void IsRectangular_Rectangular_ReturnsTrue()
    {
        //Arrange
        var triangle = new Triangle(12, 9, 15);
        //Act
        var result = triangle.IsRectangular();
        //Assert
        Assert.True(result);
    }
    [Fact]
    public void IsRectangular_Rectangular_ReturnsFalse()
    {
        //Arrange
        var triangle = new Triangle(12, 10, 15);
        //Act
        var result = triangle.IsRectangular();
        //Assert
        Assert.False(result);
    }
}