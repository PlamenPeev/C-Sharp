using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        //Arrange
        string input = "";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(string.Empty));


    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        //Arrange
        string input = "Dog";
        string expected = "dog";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {

        //Arrange
        string input = "dog cat chicken";
        string expected = "dogCatChicken";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        //Arrange
        string input = "Pesho have a dog";
        string expected = "peshoHaveADog";

        //Act
        string result = CamelCaseConverter.ConvertToCamelCase(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
