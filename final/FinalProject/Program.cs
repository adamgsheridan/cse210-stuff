using System;
class Program
{
    static void Main(string[] args)
    {
        Account account = new Account();
        Menu menu = new Menu();
        int mainSelector = menu.MainMenu();
        AccountManager accountManager = new AccountManager();
        while (mainSelector != 6)
        {
            if (mainSelector == 1)
            {
                int newAcc = menu.CreationMenu();
                string name = account.GetName();
                float balance = account.GetBalance();
                string address = account.GetAddress();
                int accountNumber = account.GetAccountNumber();
                int routingNumber = account.GetRoutingNumber();
                if (newAcc == 1)
                {
                    float overdraftFee = CheckingAccount.GetOverdraftFee();
                    Account newChecking = new CheckingAccount(name, balance, address, accountNumber, routingNumber, overdraftFee);
                    accountManager.CreateAccount(newChecking);
                }
                else if (newAcc == 2)
                {
                    float interestRate = SavingsAccount.GetInterestRate();
                    int transactionLimit = SavingsAccount.GetTransactionLimit();
                    Account newSavings = new SavingsAccount(name, balance, address, accountNumber, routingNumber, interestRate, transactionLimit);
                    accountManager.CreateAccount(newSavings);
                }
            }
            else if (mainSelector == 2)
            {
                accountManager.GetInterest();
            }
            else if (mainSelector == 3)
            {
                // Save Account.
            }
            else if (mainSelector == 4)
            {
                // Load Account.
            }
            else if (mainSelector == 5)
            {
                // Delete Account.
            }
            mainSelector = menu.MainMenu();
        }
    }
}