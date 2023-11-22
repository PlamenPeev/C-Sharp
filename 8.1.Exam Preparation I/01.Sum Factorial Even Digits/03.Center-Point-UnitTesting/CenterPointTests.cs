using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        //Arange
        double pointOne = Math.Abs(1) + Math.Abs(2);
        double pointTwo = Math.Abs(3) + Math.Abs(4);

        string firstPointReport = $"({string.Join(", ", 1, 2)})";
        string secondPointReport = $"({string.Join(", ", 3, 4)})";

        //Act
        string result = CenterPoint.GetClosest(1,2,3,4);

        //Assert
        Assert.That(result, Is.EqualTo(firstPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        //Arange
        double pointOne = Math.Abs(3) + Math.Abs(4);
        double pointTwo = Math.Abs(1) + Math.Abs(2);

        string firstPointReport = $"({string.Join(", ", 3, 4)})";
        string secondPointReport = $"({string.Join(", ", 1, 2)})";

        //Act
        string result = CenterPoint.GetClosest(3, 4, 1, 2);

        //Assert
        Assert.That(result, Is.EqualTo(secondPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        //Arange
        double pointOne = Math.Abs(3) + Math.Abs(4);
        double pointTwo = Math.Abs(3) + Math.Abs(4);

        string firstPointReport = $"({string.Join(", ", 3, 4)})";
        string secondPointReport = $"({string.Join(", ", 3, 4)})";

        //Act
        string result = CenterPoint.GetClosest(3, 4, 3, 4);

        //Assert
        Assert.That(result, Is.EqualTo(firstPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        //Arange
        double pointOne = Math.Abs(-1) + Math.Abs(-2);
        double pointTwo = Math.Abs(3) + Math.Abs(4);

        string firstPointReport = $"({string.Join(", ", -1, -2)})";
        string secondPointReport = $"({string.Join(", ", 3, 4)})";

        //Act
        string result = CenterPoint.GetClosest(-1, -2, 3, 4);

        //Assert
        Assert.That(result, Is.EqualTo(firstPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {

        //Arange
        double pointOne = Math.Abs(3) + Math.Abs(4);
        double pointTwo = Math.Abs(-3) + Math.Abs(-4);

        string firstPointReport = $"({string.Join(", ", 3, 4)})";
        string secondPointReport = $"({string.Join(", ", -3, -4)})";

        //Act
        string result = CenterPoint.GetClosest(3, 4, -3, -4);

        //Assert
        Assert.That(result, Is.EqualTo(secondPointReport));
    }
}
