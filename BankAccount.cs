// this class represents a bank account and will be used by the AccountManager class
//The BankAccount class represents the blueprint or structure of a bank account within the banking system. 
//It encapsulates the attributes and functionalities related to an individual bank account.
public class BankAccount
{
    public int AccountNumber { get; private set; }
    public string AccountHolder { get; set; }
    public decimal Balance { get; private set; }

//constuctor
    public BankAccount(int accountNumber, string accountHolder, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

//methods
    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Account Balance: {Balance:C}");
    }
}
