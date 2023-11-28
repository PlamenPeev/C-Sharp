using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'k';
        char b = 'l';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        //Arrange
        char a = 'A';
        char b = 'B';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        //Arrange
        char a = 'A';
        char b = 'C';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo("B"));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        //Arrange
        char a = 'D';
        char b = 'G';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo("E F"));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        //Arrange
        char a = 'X';
        char b = 'Z';

        //Act
        string result = CharacterRange.GetRange(a, b);

        //Assert
        Assert.That(result, Is.EqualTo("Y"));
    }
}
