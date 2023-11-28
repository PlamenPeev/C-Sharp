using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        // Arrange
        string[] input = { };

        //Act
        bool isValid = BalancedBrackets.IsBalanced(input);

        //Assert
        Assert.IsTrue(isValid);

    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        // Arrange
        string[] input = { "(", ")", "(", ")", "(", ")" };

        //Act
        bool isValid = BalancedBrackets.IsBalanced(input);

        //Assert
        Assert.IsTrue(isValid);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = { "(", ")", "(", ")", "(" };

        //Act
        bool isValid = BalancedBrackets.IsBalanced(input);

        //Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = { "(", ")", ")", "(", ")", "(", ")", ")" };

        //Act
        bool isValid = BalancedBrackets.IsBalanced(input);

        //Assert
        Assert.IsFalse(isValid);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        // Arrange
        string[] input = { "(", "(", "(" };

        //Act
        bool isValid = BalancedBrackets.IsBalanced(input);

        //Assert
        Assert.IsFalse(isValid);
    }
}
