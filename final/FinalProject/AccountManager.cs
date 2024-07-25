class AccountManager
{
    public List<Account> _accounts = new List<Account>();

    Account account = new Account();
    public void CreateAccount(Account account)
    {
        _accounts.Add(account);
    }


    public void GetInterest()
    {
        Console.Write("What is the Account Number of the account to be used to calculate interest? ");
        int tempAccNum;
        tempAccNum = int.Parse(Console.ReadLine());
        foreach (Account account in _accounts)
        {
            Console.WriteLine("We made it this far");
            if(account.GetAccount(tempAccNum) == true)
            {
                float tempBalance = account.CalculateInterest();
                double interest = tempBalance * .0008;
                Console.WriteLine($"The yearly interest for that account is ${interest}.");
                Console.WriteLine();
            }
        }

    }

    
}