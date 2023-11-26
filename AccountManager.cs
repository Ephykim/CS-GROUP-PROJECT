//AccountManager class acts as a control center or manager for handling various operations/func related to bank accounts.
public class AccountManager
{
    private List<BankAccount> accounts = new List<BankAccount>();

    public void CreateAccount(int accountNumber, string accountHolder, decimal initialBalance)
    {
        BankAccount newAccount = new BankAccount(accountNumber, accountHolder, initialBalance);
        accounts.Add(newAccount);
        Console.WriteLine("Account created successfully.");
    }

//next func has a return type of BankAccount, indicating that it will return an instance of the BankAccount class.
//acc is the placeholder variable representing each BankAccount instance as the Find method traverses through the list.
    public BankAccount FindAccount(int accountNumber)
    {
        return accounts.Find(acc => acc.AccountNumber == accountNumber);
    }

    public void Deposit(int accountNumber, decimal amount)
    {
        //BankAccount is the data type or class name.
        BankAccount account = FindAccount(accountNumber);
        if (account != null)
        {
            account.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void Withdraw(int accountNumber, decimal amount)
    {
        BankAccount account = FindAccount(accountNumber);
        if (account != null)
        {
            account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void DisplayBalance(int accountNumber)
    {
        BankAccount account = FindAccount(accountNumber);
        if (account != null)
        {
            account.DisplayBalance();
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    public void DeleteAccount(int accountNumber)
    {
        BankAccount account = FindAccount(accountNumber);
        if (account != null)
        {
            accounts.Remove(account);
            Console.WriteLine("Account deleted successfully.");
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }
}
