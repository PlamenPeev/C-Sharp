using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = new string[] {};

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "gold 8", "silver 30"};

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new string[] { "gold 10", "silver 100", "Gold 30", "siLver 30" };

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 40{Environment.NewLine}silver -> 130"));
    }
}
