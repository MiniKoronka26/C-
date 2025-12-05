using System.Security.Principal;

namespace _010_Collections
{
    class Person : IComparable
    {
        public string LastName {  get; set; }
        public int Age { get; set; }

        public Person()
        {
            LastName = "lastName";
            Age = 0;
        }
        public Person(string lastName, int age)
        {
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"lastname: {LastName}, age: {Age}";
        }

        public int CompareTo(object? obj)
        {

            if ((obj is Person))
            {
                Person other = (obj as Person);
                return other.LastName.CompareTo(this.LastName);
            }
            throw new NotImplementedException();
        }
    }
}
