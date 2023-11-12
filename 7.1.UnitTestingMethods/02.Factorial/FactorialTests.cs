using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int n = 0;

        // Act
        int result = Factorial.CalculateFactorial(n);

        // Assert
        Assert.AreEqual(1, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int n = 5;

        // Act
        int result = Factorial.CalculateFactorial(n);

        // Assert
        Assert.AreEqual(120, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int n = - 10;

        // Act
        int result = Factorial.CalculateFactorial(n);


        // Assert

        Assert.That(() => Factorial.CalculateFactorial(n), Throws.ArgumentException );
       
    }
}

