using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? input = null;

        // Act + Assert
        Assert.That(() => { Pattern.SortInPattern(input); }, Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 2, 5, 4 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1, 5, 2, 4, 3 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] numbers = new int[] { 4 };

        // Act
        int[] result = Pattern.SortInPattern(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 4 }));
    }
}
