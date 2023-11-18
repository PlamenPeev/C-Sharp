using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        // Arrange
        long num = 1;


        // Act & Assert
        Assert.That(() => { PrimeFactor.FindLargestPrimeFactor(num); }, Throws.ArgumentException);
    }


    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
         // Arrange
         long num = 29;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(num);

        //Assert
        Assert.That(result, Is.EqualTo(29));

    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        // Arrange
        long num = 97;

        // Act
        long result = PrimeFactor.FindLargestPrimeFactor(num);

        //Assert
        Assert.That(result, Is.EqualTo(97));
    }
}
