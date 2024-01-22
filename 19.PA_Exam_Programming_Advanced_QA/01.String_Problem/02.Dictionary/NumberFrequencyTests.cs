using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        //Arrange
        int number = 0;
        Dictionary<int, int> expected = new() {};

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        //Assert
        Assert.That(expected, Is.EquivalentTo(result));

    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        //Arrange
        int number = 3;
        Dictionary<int, int> expected = new()
        {
           { 3, 1},
         };

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        //Assert
        Assert.That(expected, Is.EquivalentTo(result));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Arrange
        int number = 1232;
        Dictionary<int, int> expected = new()
        {
          { 1, 1},
          { 2, 2},
          { 3, 1},
         };

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        //Assert
        Assert.That(expected, Is.EquivalentTo(result));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        //Arrange
        int number = -1232;
        Dictionary<int, int> expected = new()
        {
          { 1, 1},
          { 2, 2},
          { 3, 1},
         };

        //Act
        Dictionary<int, int> result = NumberFrequency.CountDigits(number);

        //Assert
        Assert.That(expected, Is.EquivalentTo(result));
    }
}
