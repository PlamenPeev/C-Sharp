using System.Collections.Generic;

using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int>? fruits = new Dictionary<string, int>()
        {
            { "orange", 2},
            { "peach", 11},
            { "pear", 4}
        };
        string name = "peach";
        int expectedQNT = 11;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, name);

        //Assert
        Assert.AreEqual(expectedQNT, result);

    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = new Dictionary<string, int>()
        {
            { "orange", 2},
            { "peach", 11},
            { "pear", 4}
        };
        string name = "apple";
        int expectedQNT = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, name);

        //Assert
        Assert.That(result, Is.EqualTo(expectedQNT));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = new() { };
        string name = "apple";
        int expectedQNT = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, name);

        //Assert
        Assert.That(result, Is.EqualTo(expectedQNT));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = null;
        string name = "apple";
        int expectedQNT = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, name);

        //Assert
        Assert.That(result, Is.EqualTo(expectedQNT));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruits = new Dictionary<string, int>()
        {
            { "orange", 2},
            { "peach", 11},
            { "pear", 4}
        };
        string? name = null;
        int expectedQNT = 0;

        //Act
        int result = Fruits.GetFruitQuantity(fruits, name);

        //Assert
        Assert.That(result, Is.EqualTo(expectedQNT));
    }
}
