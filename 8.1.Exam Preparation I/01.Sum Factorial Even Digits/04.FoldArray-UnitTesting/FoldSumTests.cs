using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[] {1,2,1,2,3,4,1,2}, "3 3 5 5")]
    [TestCase(new int[] { 1, 2, 1, 2}, "3 3")]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, "5 5 13 13")]
    [TestCase(new int[] {}, "")]
    [TestCase(new int[] {-1,1,1,-1}, "0 0")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arrange
        //arr = new int[] { 1, 2, 1, 2, 3, 4, 1, 2 };
         //expected = "3355";

        //Act
        string result = FoldSum.FoldArray(arr);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }
}
