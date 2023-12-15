using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { };

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] 
        {
            "apple 5.97 1",
            "banana 3.75 1",
            "orange 1.98 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 2.00 3.05",
            "banana 3.00 5.03",
            "orange 5.00 2.04"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.10{Environment.NewLine}banana -> 15.09" +
            $"{Environment.NewLine}orange -> 10.20"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 2.33 3.00",
            "banana 3.00 5.00",
            "orange 0.99 2.00"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.99{Environment.NewLine}banana -> 15.00" +
            $"{Environment.NewLine}orange -> 1.98"));
    }
}
