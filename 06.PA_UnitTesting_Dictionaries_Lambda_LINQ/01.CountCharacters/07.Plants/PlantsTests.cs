using NUnit.Framework;

using System;
using System.Text;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = new string[] {};

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] {"rose"};
        StringBuilder sb = new();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("rose");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "rose", "lily", "daisy", "abcd", "yo" };
        StringBuilder sb = new();
        sb.AppendLine("Plants with 2 letters:");
        sb.AppendLine("yo");
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("rose");
        sb.AppendLine("lily");
        sb.AppendLine("abcd");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("daisy");

        string expected = sb.ToString().Trim();
        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "rose", "daisy", "lily", "Mushkato" };
        StringBuilder sb = new();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("rose");
        sb.AppendLine("lily");
        sb.AppendLine("Plants with 5 letters:");
        sb.AppendLine("daisy");
        sb.AppendLine("Plants with 8 letters:");
        sb.AppendLine("Mushkato");

        string expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
