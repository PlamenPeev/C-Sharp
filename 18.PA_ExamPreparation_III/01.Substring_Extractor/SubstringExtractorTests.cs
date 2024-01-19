using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class SubstringExtractorTests
{
    [Test]
    public void Test_ExtractSubstringBetweenMarkers_SubstringFound_ReturnsExtractedSubstring()
    {
        //Arrange
        string input = "Hello very dificulte test";
        string start = "o ";
        string end = " d";


        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result, Is.EqualTo("very"));

    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Hello very dificulte test";
        string start = "Jack";
        string end = "test";
        

        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result,Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EndMarkerNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Hello very dificulte test";
        string start = "Hello";
        string end = "no marker";


        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersNotFound_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "Hello very dificulte test";
        string start = "abcmarker";
        string end = "dfjmarker";


        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_EmptyInput_ReturnsNotFoundMessage()
    {
        //Arrange
        string input = "";
        string start = "ab";
        string end = "lo";


        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersOverlapping_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello very dificulte test";
        string start = "Hello very";
        string end = "very";


        //Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, start, end);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    //////////////////////////////////////////////////////////////////////////////////////////////////
    

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_StartAndEndMarkersSame_ReturnsEmptyString()
    {
        // Arrange
        string input = "Hello very dificulte test";
        string startMarker = "very";
        string endMarker = "very";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_MarkersInReverseOrder_ReturnsNotFoundMessage()
    {
        // Arrange
        string input = "Hello very dificulte test";
        string startMarker = "test";
        string endMarker = "very";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_MultiOccurrence_ReturnsFirstOccurrence()
    {
        // Arrange
        string input = "Hello very dificulte test. That test is not easy.";
        string startMarker = "very";
        string endMarker = "test";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.AreEqual(" dificulte ", result);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_CaseInsensitive_ReturnsExtractedSubstring()
    {
        // Arrange
        string input = "Hello very dificulte test";
        string startMarker = "VERY";
        string endMarker = "TEST";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        // Assert
        Assert.AreEqual("Substring not found", result);
    }

    [Test]
    public void Test_ExtractSubstringBetweenMarkers_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;
        string startMarker = "start";
        string endMarker = "end";

        // Act
        string result = SubstringExtractor.ExtractSubstringBetweenMarkers(input, startMarker, endMarker);

        //Assert
        Assert.That(result, Is.EqualTo("Substring not found"));
    }
}
