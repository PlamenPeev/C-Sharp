using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { };
        string text = "I love my wife";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = { "friend"};
        string text = "I love my wife. She is the best friend.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo("I love my wife. She is the best ******."));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {

        // Arrange
        string[] bannedWords = new string[] {};
        string text = "I love my wife";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { "fri end", "wif e" };
        string text = "I love my wif e. She is the best fri end.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo("I love my *****. She is the best *******."));
    }
}
