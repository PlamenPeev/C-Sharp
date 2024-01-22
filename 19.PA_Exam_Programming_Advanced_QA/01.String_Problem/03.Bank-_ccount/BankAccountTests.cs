using NUnit.Framework;

namespace TestApp.Tests;


[TestFixture]
public class BankAccountTests
{

    
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        //Arrange
        BankAccount account = new BankAccount(100.50);

        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(balance, Is.EqualTo(100.50));


    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        //Arrange
        BankAccount account = new BankAccount(100.50);
        double deposit = 50.20;
        account.Deposit(deposit);
        double expected = 100.50 + 50.20;

        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(balance, Is.EqualTo(expected));


    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        //Arrange
        BankAccount account = new BankAccount(100.50);
        double deposit = -50.20;
       

        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(() => account.Deposit(deposit), Throws.ArgumentException);
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        BankAccount account = new BankAccount(100.50);
        double withdraw = 40.20;
        account.Withdraw(withdraw);
        double expected = 100.50 - 40.20;

        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(balance, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount(100.50);
        double withdraw = -40.20;
      

        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(() => account.Withdraw(withdraw), Throws.ArgumentException);


    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        BankAccount account = new BankAccount(100.50);
        double withdraw = 260.45;


        //Act
        double balance = account.Balance;

        //Assert
        Assert.That(() => account.Withdraw(withdraw), Throws.ArgumentException);
    }
}
