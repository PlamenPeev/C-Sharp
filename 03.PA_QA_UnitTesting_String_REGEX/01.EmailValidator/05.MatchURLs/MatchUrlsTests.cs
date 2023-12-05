using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";
        List<string> expected = new();

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "Not valid URL in the text";

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = " That URL https://www.abv.bg is valid";
        List<string> expected = new() { "https://www.abv.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = " That URL https://www.abv.bg is valid. Olso thta urs is valid - https://judge.softuni.org";
        List<string> expected = new List<string>{ "https://www.abv.bg", "https://judge.softuni.org" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "That URL \"https://www.abv.bg is valid\"";
        List<string> expected = new() { "https://www.abv.bg" };

        // Act
        List<string> result = MatchUrls.ExtractUrls(text);


        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
