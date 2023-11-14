using NUnit.Framework;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);

    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> numbers = new List<int>{ 4 };
        // Act
        int maxNum = MaxNumber.FindMax(numbers);

        // Assert
        Assert.IsTrue(maxNum == 4);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { 4, 5, 40, 65 };
        // Act
        int maxNum = MaxNumber.FindMax(numbers);

        // Assert
        Assert.IsTrue(maxNum == 65);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -4, -5, -40, -65 };
        // Act
        int maxNum = MaxNumber.FindMax(numbers);

        // Assert
        Assert.IsTrue(maxNum == -4);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -4, -5, 7, -65 };
        // Act
        int maxNum = MaxNumber.FindMax(numbers);

        // Assert
        Assert.IsTrue(maxNum == 7);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> numbers = new List<int> { -4, -5, 7, -65, 7, -5 };
        // Act
        int maxNum = MaxNumber.FindMax(numbers);

        // Assert
        Assert.IsTrue(maxNum == 7);
    }
}
