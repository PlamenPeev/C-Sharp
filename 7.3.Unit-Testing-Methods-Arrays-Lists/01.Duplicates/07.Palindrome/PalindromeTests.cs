using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
   
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "alaala" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    
    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        // Arrange
        List<string> words = new();

        // Act
        bool result = Palindrome.IsPalindrome(words);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "bananab" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        // Arrange
        List<string> input = new() { "word" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsFalse(result);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        // Arrange
        List<string> input = new() { "PalaYalaP" };

        // Act
        bool result = Palindrome.IsPalindrome(input);

        // Assert
        Assert.IsTrue(result);
    }
}
