using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int size = 0;
        // Act
        string result = Triangle.PrintTriangle(size);
        

        // Assert
        Assert.AreEqual("", result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int size = 3;
        // Act
        string result = Triangle.PrintTriangle(size);


        // Assert
        Assert.AreEqual("1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1", result);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int size = 5;
        // Act
        string result = Triangle.PrintTriangle(size);


        // Assert
        Assert.AreEqual("1" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3 4 5" + Environment.NewLine +
            "1 2 3 4" + Environment.NewLine +
            "1 2 3" + Environment.NewLine +
            "1 2" + Environment.NewLine +
            "1", result);
    }
}

