using System.Collections;

namespace _008_StandartInterfacesTask
{
    class Bank
    {
        Account[] accounts = {
            new Account {Surname = "John", AccountLogin = "user1", AccountPassword = "pass5", GreatedTime = new DateTime(2020,06,21), Balance = 20000 },
            new Account {Surname = "Alex", AccountLogin = "user3", AccountPassword = "pass20", GreatedTime = new DateTime(2025,01,01), Balance = 10000 },
            new Account {Surname = "Dan", AccountLogin = "user2", AccountPassword = "pass1", GreatedTime = new DateTime(2015,10,17), Balance = 30000 }
        };

        public int Length
        {
            get { return accounts.Length; }
        }
        public Account this[int index]
        {
            get { return accounts[index]; }
        }

        public void Sort()
        {
            Array.Sort(accounts);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(accounts, comparer);
        }

    }
}
