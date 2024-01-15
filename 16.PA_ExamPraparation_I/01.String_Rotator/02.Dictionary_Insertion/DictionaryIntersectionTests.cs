using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary< string, int> dict2 = new Dictionary<string, int>();

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
       //Assert.That(result, Has.Count.EqualTo(0));


    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { ["abc"] = 1, ["hello"] = 3};
        Dictionary<string, int> dict2 = new Dictionary<string, int>();

        //Dictionary<string, int> dict = new () 
        //{
        //    { "abc", 1}, 
        //    { "hello", 3}, 
        //};


        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { ["abc"] = 1, ["hello"] = 3 };
        Dictionary<string, int> dict2 = new Dictionary<string, int>() { ["c"] = 1, ["hi"] = 3 };

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { ["abc"] = 1, ["hello"] = 3 };
        Dictionary<string, int> dict2 = new Dictionary<string, int>() { ["hello"] = 3, ["hi"] = 3 };
        Dictionary<string, int> expected = new Dictionary<string, int>() { ["hello"] = 3};


        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(expected, Is.EquivalentTo(result));
        Assert.AreEqual(1, result.Count);
        Assert.IsTrue(result.ContainsKey("hello"));
        Assert.IsFalse(result.ContainsKey("abc"));
        Assert.AreEqual(3, result["hello"]);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        //Arrange
        Dictionary<string, int> dict1 = new Dictionary<string, int>() { ["abc"] = 1, ["hello"] = 3 };
        Dictionary<string, int> dict2 = new Dictionary<string, int>() { ["hello"] = 5, ["abc"] = 6 };
      

        //Act
        Dictionary<string, int> result = DictionaryIntersection.Intersect(dict1, dict2);

        //Assert
        Assert.That(result, Is.Empty);
        Assert.IsTrue(!result.Any());
    }
}
