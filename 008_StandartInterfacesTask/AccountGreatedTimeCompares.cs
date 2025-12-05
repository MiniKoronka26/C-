using System.Collections;

namespace _008_StandartInterfacesTask
{
    class AccountGreatedTimeCompares : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Account && y is Account)
            {
                return (x as Account).GreatedTime
                    .CompareTo((y as Account).GreatedTime);
            }
            throw new NotImplementedException();
        }
    }
}
