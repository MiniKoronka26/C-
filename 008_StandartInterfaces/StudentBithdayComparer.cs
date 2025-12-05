using System.Collections;
namespace _008_StandartInterfaces
{
    class StudentBithdayComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).BirthDate
                    .CompareTo((y as Student).BirthDate);
            }
            throw new NotImplementedException();
        }
    }
}
