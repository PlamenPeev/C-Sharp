using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => AdjacentEqual.Sum(nullList), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);
        // Assert
        Assert.IsEmpty(result);

    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 3, 3, 4, 5, 3, 3 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 6 4 5 6"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> numbers = new List<int> { 4, 2, 2, 4, 2, 2 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("16"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 2, 2, 3, 5, 2 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("4 3 5 2"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 5, 5 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 10"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 3, 5 ,6 };
        // Act
        string result = AdjacentEqual.Sum(numbers);
        // Assert
        Assert.That(result, Is.EqualTo("1 2 6 5 6"));
    }
}
