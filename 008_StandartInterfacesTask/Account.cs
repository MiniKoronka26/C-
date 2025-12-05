namespace _008_StandartInterfacesTask
{
    class Account : IComparable
    {
        public string Surname { set; get; }
        public string AccountLogin { set; get; }
        public string AccountPassword { set; get; }
        public DateTime GreatedTime { get; set; }
        public int Balance { get; set; }


        public int CompareTo(object? obj)
        {
            if ((obj is Account))
            {
                Account other = (obj as Account);
                return this.Surname.CompareTo(other.Surname);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, Login: {AccountLogin}, Password: {AccountPassword}, GreatedTime: {GreatedTime}, Balance: {Balance}";
        }

    }
}
