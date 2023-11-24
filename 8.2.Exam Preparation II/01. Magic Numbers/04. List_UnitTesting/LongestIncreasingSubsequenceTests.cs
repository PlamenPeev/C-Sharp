using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        //Arrange
        int[]? arr = null;

        //Act & Assert
        Assert.That(() =>  LongestIncreasingSubsequence.GetLis(arr), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        //Arrange
        int[] arr = Array.Empty<int>();

        //Act
        string result = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        //Arrange
        int[] arr = new int[] { 2 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(result, Is.EqualTo("2"));

    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {

        //Arrange
        int[] arr = new int[] { 1, 2, 4, 7, 2, 4, 3 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(result, Is.EqualTo("1 2 4 7"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] arr = new int[] { 1, 2, 4, 7, 2, 4, 3 };

        //Act
        string result = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(result, Is.EqualTo("1 2 4 7"));
    }
}
