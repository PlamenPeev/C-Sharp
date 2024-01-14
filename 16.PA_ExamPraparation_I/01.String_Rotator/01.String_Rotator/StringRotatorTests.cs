using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = "";
        int rotator = 1;

        //Act
        string result = StringRotator.RotateRight(input, rotator);

        //Assert
        Assert.That(result, Is.EqualTo(input));

    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        //Arrange
        string input = "abcd";
        int rotator = 0;

        //Act
        string result = StringRotator.RotateRight(input, rotator);

        //Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "Hello word";
        int rotator = 1;

        //Act
        string result = StringRotator.RotateRight(input, rotator);

        //Assert
        Assert.That(result, Is.EqualTo("dHello wor"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        //Arrange
        string input = "Hello word";
        int rotator = -1;

        //Act
        string result = StringRotator.RotateRight(input, rotator);

        //Assert
        Assert.That(result, Is.EqualTo("dHello wor"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        //Arrange
        string input = "abc";
        int rotator = 4;

        //Act
        string result = StringRotator.RotateRight(input, rotator);

        //Assert
        Assert.That(result, Is.EqualTo("cab"));
    }
}
