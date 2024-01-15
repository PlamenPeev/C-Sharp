using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct1_ProductAddedToInventory()
    {
        //Arrange
        string name = "table";
        double price = 30.50;
        int quantity = 1;
      

        //Act
        _inventory.AddProduct(name, price, quantity);


        //Assert
       

    }

    [Test]
    public void Test_DisplayInventory_NoProducts1_ReturnsEmptyString()
    {
        /// Arrange

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.AreEqual("Product Inventory:", result);
    }

    [Test]
    public void Test_DisplayInventory_WithProducts1_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("Product1", 20.5, 3);
        _inventory.AddProduct("Product2", 15.75, 2);

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        StringAssert.Contains("Product1", result);
        StringAssert.Contains("Product2", result);
        StringAssert.Contains("Price: $20.50", result);
        StringAssert.Contains("Quantity: 3", result);
        StringAssert.Contains("Price: $15.75", result);
        StringAssert.Contains("Quantity: 2", result);
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts1_ReturnsZero()
    {
        // Arrange

        // Act
        double totalValue = _inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(0, totalValue);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts1_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("Product1", 20.5, 3);
        _inventory.AddProduct("Product2", 15.75, 2);

        // Act
        double totalValue = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(totalValue, Is.EqualTo((20.5 * 3) + (15.75 * 2)));
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        //Arrange
        string name = "table";
        double price = 30.50;
        int quantity = 1;

        string expectedInventory = $"Product Inventory:{Environment.NewLine}{name} - Price: ${price:f2} - Quantity: {quantity}";

        //Act
        this._inventory.AddProduct(name, price, quantity);

        string result = this._inventory.DisplayInventory();

        //Assert
        Assert.AreEqual(expectedInventory, result);

    }

    

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string name1 = "table";
        double price1 = 30.50;
        int quantity1 = 1;

        string name2 = "vase";
        double price2 = 15.20;
        int quantity2 = 2;
        string expectedInventory = $"Product Inventory:{Environment.NewLine}{name1} - Price: ${price1:f2} - Quantity: {quantity1}" +
            $"{Environment.NewLine}{name2} - Price: ${price2:f2} - Quantity: {quantity2}";

        // Act
        this._inventory.AddProduct(name1, price1, quantity1);
        this._inventory.AddProduct(name2, price2, quantity2);
        string result = this._inventory.DisplayInventory();

        // Assert
        Assert.AreEqual (expectedInventory, result);
    }

 

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string name1 = "table";
        double price1 = 30.50;
        int quantity1 = 1;

        string name2 = "vase";
        double price2 = 15.20;
        int quantity2 = 2;

        double expectedSum = 60.90;
        // Act
        this._inventory.AddProduct(name1, price1, quantity1);
        this._inventory.AddProduct(name2, price2, quantity2);
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expectedSum));
    }
}
