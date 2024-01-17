using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        //Arrange
        string input = string.Empty;
        //string[] expected = Array.Empty<string>();


        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.AreEqual(0, result.Length);
        Assert.That(result, Is.Not.Null);
        Assert.That(result.Length, Is.EqualTo(0));
        //Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        //Arrange
        string input = "table";
        string[] expected = new string[] { "table" };

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        //Arrange
        string input = "table,chear,vase";
        string[] expected = new string[] { "table", "chear", "vase" };

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.AreEqual(3, result.Length);

    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        //Arrange
        string input = " one,   two,three ";
        string[] expected = new string[] { "one", "two", "three" };

        //Act
        string[] result = CsvParser.ParseCsv(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
        //Assert.AreEqual(3, result.Length);
        //Assert.AreEqual("table", result[0]);
        //Assert.AreEqual("chear", result[1]);
        //Assert.That(result[2], Is.EqualTo("vase"));

    }
}
