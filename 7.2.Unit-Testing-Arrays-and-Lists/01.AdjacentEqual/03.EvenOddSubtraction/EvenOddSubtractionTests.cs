using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = new int[0];

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] arr = { 10, 10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr); ;

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] arr = { 1, 3 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr); ;

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] arr = { 1, 3, 2, 4 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr); ;

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
