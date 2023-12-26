using NUnit.Framework;

using System;
using System.Diagnostics.Metrics;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        this._article = new Article();
    }

    
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData =
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3"
        };


        // Act
        Article result = this._article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article inputArticle = new Article()
        {
              ArticleList = new()
              {
                new Article()
                {
                    Author = "Plamen",
                    Content = "Some content",
                    Title = "Secret letter"
                },
                new Article()
                {
                    Author = "Pesho",
                    Content = "Any content",
                    Title = "News forbiden letter"
                }
              }
        };

        string exected = $"News forbiden letter - Any content: Pesho" +
            $"{Environment.NewLine}Secret letter - Some content: Plamen";
        // Act
        string result = this._article.GetArticleList(inputArticle, "title");

        // Assert
        Assert.AreEqual(exected, result);
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article inputArticle = new Article()
        {
            ArticleList = new()
              {
                new Article()
                {
                    Author = "Plamen",
                    Content = "Some content",
                    Title = "Secret letter"
                },
                new Article()
                {
                    Author = "Pesho",
                    Content = "Any content",
                    Title = "News forbiden letter"
                }
              }
        };

        
        // Act
        string result = this._article.GetArticleList(inputArticle, "not a title");

        // Assert
        Assert.AreEqual(string.Empty, result);
    }
}
