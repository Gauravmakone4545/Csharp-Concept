using System;

class BankAccount
{
    private int balance;     // private field

    public void SetBalance(int amount)     // setter
    {
        balance = amount;
    }

    public int GetBalance()   // getter
    {
        return balance;
    }
}

class Test
{
    static void Main()
    {
        BankAccount b = new BankAccount();
        b.SetBalance(5000);

        Console.WriteLine(b.GetBalance());
    }
}
