using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{

    [TestCase("ivan.ivanov@abv.bg")]
    [TestCase("P.peshov@gmail.com")]
    [TestCase("s_sashov@meil.ru")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }


    [TestCase("ivan_A/bg.ivanov@abv.bg")]
    [TestCase("propa.peshov.yahoo.com")]
    [TestCase("sasho.sd.sashov@bg@org")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
