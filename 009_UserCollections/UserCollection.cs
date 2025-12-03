using System.Collections;

namespace _009_UserCollections
{
    class UserCollection : IEnumerable
    {
        int pos = -1;

        Element[] elementsArray = new Element[]{
            new Element("A", 1, 10),
            new Element("B", 2, 20),
            new Element("C", 3, 30),
            new Element("D", 4, 40),
        };

        public IEnumerator GetEnumerator()
        {
            //return new UserCollectionEnumerator(elementsArray);

            return elementsArray.GetEnumerator();
        }
    }
}
