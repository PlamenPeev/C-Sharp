using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() {""};

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "b" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("b -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "b", "c", "cd", "eff" };
        StringBuilder sb = new();
        sb.AppendLine("b -> 1");
        sb.AppendLine("c -> 2");
        sb.AppendLine("d -> 1");
        sb.AppendLine("e -> 1");
        sb.AppendLine("f -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "b", "&", "&d", "*ff" };
        StringBuilder sb = new();
        sb.AppendLine("b -> 1");
        sb.AppendLine("& -> 2");
        sb.AppendLine("d -> 1");
        sb.AppendLine("* -> 1");
        sb.AppendLine("f -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNumbers_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "1", "2", "12", "33" };

        StringBuilder sb = new();
        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 2");
        sb.AppendLine("3 -> 2");

        string expected = sb.ToString().Trim();
        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
