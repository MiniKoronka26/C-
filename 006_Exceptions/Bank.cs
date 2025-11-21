namespace _006_Exceptions
{
    class Bank
    {
        List<Account> accounts;

        public Bank(List<Account> accounts)
        {
            this.accounts = accounts;
        }
        public void Withdraw(Account account, int amout)
        {
            bool isExists = false;
            foreach (var item in accounts)
            {
                if (item.ID == account.ID)
                    isExists = true;
            }

            if (!isExists)
            {
                throw new NotFoundAccountException("Not found", account);
            }
        }
    }
}
