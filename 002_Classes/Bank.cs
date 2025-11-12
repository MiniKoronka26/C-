namespace _003_Classes
{
    class Bank
    {
        static int balance = 10000;
        
        public void Deposit(int amout)
        {
            balance += amout;
        }
        
        public void Credit(int amout)
        {
            balance -= amout;
        }
        public static int GetBalance()
        {
            return balance;
        }
    }
}
