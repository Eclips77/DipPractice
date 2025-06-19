using System;
using System.Collections.Generic;

public interface IAccount
{
    decimal GetBalance();
}

public class BankAccount : IAccount
{
    public decimal CashBalance { get; set; }

    public BankAccount(decimal amount)
    {
        CashBalance = amount;
    }

    public decimal GetBalance()
    {
        return CashBalance;
    }
}

public class DebtAccount : IAccount
{
    public decimal DebtAmount { get; set; }

    public DebtAccount(decimal debtAmount)
    {
        DebtAmount = debtAmount;
    }

    public decimal GetBalance()
    {
        return -DebtAmount;
    }
}



