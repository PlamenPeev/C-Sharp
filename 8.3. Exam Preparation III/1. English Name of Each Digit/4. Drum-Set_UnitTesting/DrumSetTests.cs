using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100.5M;
        List< int > initialQuality = new List< int>() { 10, 20, 30};
        List<string> commands = new List<string>() { };

        //Act & Assert
        Assert.That(() => DrumSet.Drum(money,initialQuality,commands), Throws.InstanceOf<ArgumentException>());

    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        //Arrange
        decimal money = 100.5M;
        List<int> initialQuality = new List<int>() { 10, 20, 30 };
        List<string> commands = new List<string>() { "aa", "bb", "cc" };

        //Act & Assert
        Assert.That(() => DrumSet.Drum(money, initialQuality, commands), Throws.ArgumentException);
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 100.5M;
        List<int> initialQuality = new List<int>() { 10, 20, 30 };
        List<string> commands = new List<string>() { "10", "5", "Hit it again, Gabsy!" };

        //Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(result, Is.EqualTo("5 5 15\nGabsy has 70.50lv."));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        //Arrange
        decimal money = 100.5M;
        List<int> initialQuality = new List<int>() { 0, 0, 3 };
        List<string> commands = new List<string>() { "10", "5", "Hit it again, Gabsy!" };

        //Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(result, Is.EqualTo("0 0 3\nGabsy has 82.50lv."));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {

        //Arrange
        decimal money = 5.5M;
        List<int> initialQuality = new List<int>() { 10, 20, 30 };
        List<string> commands = new List<string>() { "10", "5", "Hit it again, Gabsy!" };

        //Act
        string result = DrumSet.Drum(money, initialQuality, commands);

        //Assert
        Assert.That(result, Is.EqualTo("5 15\nGabsy has 5.50lv."));
    }
}
