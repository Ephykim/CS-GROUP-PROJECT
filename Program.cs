class Program
{
    static AccountManager manager = new AccountManager(); 

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Bank Account Management System");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Display Balance");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Create_Account();
                    break;
                case 2:
                    PerformDeposit();
                    break;
                case 3:
                    PerformWithdrawal();
                    break;
                case 4:
                    DisplayAccountBalance();
                    break;
                case 5:
                    exit = true;
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void Create_Account()
    {   
        Console.Write("Enter account number: ");
        int account_Number = int.Parse(Console.ReadLine());

        Console.Write("Enter account holder's name: ");
        string accountHolder = Console.ReadLine();

        Console.Write("Enter initial balance: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal initialBalance))
        {
            Console.WriteLine("Invalid initial balance. Please enter a valid amount.");
            return;
        }

        manager.CreateAccount(account_Number, accountHolder, initialBalance);
        Console.WriteLine("Account created successfully.");
    }

    static void PerformDeposit()
    {
        int accountNumber = PromptForAccountNumber();
        if (accountNumber == -1) return;

        Console.Write("Enter deposit amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid deposit amount. Please enter a valid amount.");
            return;
        }

        manager.Deposit(accountNumber, amount);
    }

    static void PerformWithdrawal()
    {
        int accountNumber = PromptForAccountNumber();
        if (accountNumber == -1) return;

        Console.Write("Enter withdrawal amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid withdrawal amount. Please enter a valid amount.");
            return;
        }

        manager.Withdraw(accountNumber, amount);
    }

    static void DisplayAccountBalance()
    {
        int accountNumber = PromptForAccountNumber();
        if (accountNumber == -1) return;

        manager.DisplayBalance(accountNumber);
    }

    static int PromptForAccountNumber()
    {
        Console.Write("Enter account number: ");
        if (!int.TryParse(Console.ReadLine(), out int accountNumber))
        {
            Console.WriteLine("Invalid account number. Please enter a valid number.");
            return -1;
        }

        return accountNumber;
    }
}

