using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => {Fake.RemoveStringNumbers(input); }, Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = new char[] {'a', 'b', '1', 'c', '2'};

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b', 'c' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = new char[] { 'a', 'b', 'c' };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b', 'c' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[] { };

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.That(result, Is.EqualTo(new char[] { }));
    }
}
