using NUnit.Framework.Internal;

namespace TestProject.Tests;

public class ShapeTests
{
    [Test]
    public void CircleArea_ShouldBeCorrect()
    {
        var circle = new Circle(5);
        var area = circle.CalculateArea();
        Assert.That(area, Is.EqualTo(78.5398).Within(0.0001));
    }

    [Test]
    public void TriangleArea_ShouldBeCorrect()
    {
        var triangle = new Triangle(3, 4, 5);
        var area = triangle.CalculateArea();
        Assert.That(area, Is.EqualTo(6).Within(0.0001));
    }

    [Test]
    public void TriangleIsRightAngled_ShouldReturnTrue()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.That(triangle.IsAngleRight(), Is.True);
    }

    [Test]
    public void TriangleIsRightAngled_ShouldReturnFalse()
    {
        var triangle = new Triangle(4, 5, 6);
        Assert.That(triangle.IsAngleRight(), Is.False);
    }
}

/*
Answer to question #2
SELECT p.ProductName, c.CategoryName
FROM Products p
LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId
ORDER BY p.ProductName;
*/