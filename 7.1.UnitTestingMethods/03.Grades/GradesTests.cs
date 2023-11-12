using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange
        double grades = 3.10;
        string expect = "Average";

        // Act
        string result = Grades.GradeAsWords(grades);

        // Assert
        Assert.AreEqual(expected, result);
    }

    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange
        double grades = 4.50;
        string expect = "Very Good";

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}

