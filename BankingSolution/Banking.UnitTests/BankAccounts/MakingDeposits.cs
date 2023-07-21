﻿
using Banking.Domain;

namespace Banking.UnitTests.BankAccounts;

public class MakingDeposits
{

    [Fact]
    public void DepositsIncreaseTheBalance()
    {
        // Given - Arrange
        var account = new BankAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100.23M;

        // When - Act
        account.Deposit(amountToDeposit); 

        // Then - Assert
        Assert.Equal(openingBalance + amountToDeposit
            , account.GetBalance());
    }

    [Fact(Skip = "just a demo")]
    public void Demo()
    {
        var jcAccount = new BankAccount();
        var joeyAccount = new BankAccount();

       
        jcAccount.Deposit(100);

       

        Assert.Equal(5100, jcAccount.GetBalance());

        Assert.Equal(5000, joeyAccount.GetBalance());
    }
}
