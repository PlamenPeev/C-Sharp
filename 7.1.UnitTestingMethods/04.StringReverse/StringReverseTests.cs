using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";
        // Act
       string reverse =  StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("",reverse);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "a";
        // Act
        string reverse = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("a", reverse);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "abc";
        // Act
        string reverse = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("cba", reverse);
    }
}
