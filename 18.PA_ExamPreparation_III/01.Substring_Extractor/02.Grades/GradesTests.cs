using System;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            {"Ivan", 5},
            {"Veronika", 4},
            {"Pesho", 2},
            {"Sasho", 3},
            {"Alex", 6},
            {"Yanislav", 5},
        };

        string expected = $"Alex with average grade 6.00" +
            $"{Environment.NewLine}Ivan with average grade 5.00" +
            $"{Environment.NewLine}Yanislav with average grade 5.00";


        //Act
        string  bestThreeGrades = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(bestThreeGrades, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            
        };

        string expected = "";


        //Act
        string bestThreeGrades = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(bestThreeGrades, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            {"Ivan", 5},
            {"Alex", 6},
            
        };

        string expected = $"Alex with average grade 6.00" +
            $"{Environment.NewLine}Ivan with average grade 5.00";


        //Act
        string bestThreeGrades = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(bestThreeGrades, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {

        //Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            {"Ivan", 6},
            {"Veronika", 4},
            {"Pesho", 2},
            {"Sasho", 3},
            {"Alex", 6},
            {"Yanislav", 6},
        };

        string expected = $"Alex with average grade 6.00" +
            $"{Environment.NewLine}Ivan with average grade 6.00" +
            $"{Environment.NewLine}Yanislav with average grade 6.00";


        //Act
        string bestThreeGrades = Grades.GetBestStudents(grades);

        //Assert
        Assert.That(bestThreeGrades, Is.EqualTo(expected));
    }
}
