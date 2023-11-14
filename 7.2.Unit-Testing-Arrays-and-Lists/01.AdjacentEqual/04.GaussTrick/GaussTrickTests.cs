using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> list = new List<int>{ 4 };
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(list, result);
    }

    
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int>{ 4, 2, 1, 3 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(new List<int> { 7, 3 }, result);
        //Assert.That(result, Is.EqualTo(new List<int> { 7, 3 }));
        
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int> { 4, 2, 1, 1, 3 };
         
        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(new List<int> { 7, 3, 1 }, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int> { 4, 2, 1, 3, 2, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(new List<int> { 9, 4, 4}, result);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int> { 7, 3, 4, 2, 1, 1, 3, 6, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(new List<int> { 11, 9, 7, 3, 1 }, result);
    }
}
