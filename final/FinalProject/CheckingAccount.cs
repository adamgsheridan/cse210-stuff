class CheckingAccount : Account
{
    private float _overdraftFee;
    public CheckingAccount(string _name, float _balance, string _address, int _accountNumber, int _routingNumber, float _overdraftFee)
    {
        this._name = _name;
        this._balance = _balance;
        this._address = _address;
        this._accountNumber = _accountNumber;
        this._routingNumber = _routingNumber;
        this._overdraftFee = _overdraftFee;
    }

    public static float GetOverdraftFee()
    {
        Console.WriteLine("How much are overdraft fees for the new account? ");
        return int.Parse(Console.ReadLine());
    }

    public override float CalculateInterest()
    {
        return _balance;
        
    }

    public override bool GetAccount(int accNum)
    {
        if(IsMatch(accNum) == true)
            {
                Console.WriteLine("This works!");
                return true;
            }
        else
        {
            Console.WriteLine("This works");
            return false;
        }
    }

}