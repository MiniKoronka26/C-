using System.Xml.Linq;

namespace _009_List_Generics
{
    class List<T>
    {
        Element<T> head, tail;
        int size;

        public List()
        {
            head = tail = default;
            size = 0;
        }

        public void add_head(T value)
        {
            Element<T> new_element = new Element<T>();
            new_element.Data = value;

            if (size == 0)
            {
                head = tail = new_element;
            }
            else
            {
                new_element.next = head;
                head = new_element;
                new_element = default;
            }
            size++;
        }
        public void add_tail(T value)
        {
            Element<T> new_element = new Element<T>();
            new_element.Data = value;

            if (size == 0)
            {
                head = tail = new_element;
            }
            else
            {
                tail.next = new_element;
                tail = new_element;
                new_element = null;
            }
            size++;
        }
        public void delete_head()
        {
            Element<T> h = head;
            if (size == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                head = head.next;
                size--;
            }
        }
        public void delete_tail()
        {
            Element<T> a = head;
            if (size == 0)
            {
                Console.WriteLine("Error");
            }
            if (size == 1)
            {
                delete_head();
                return;
            }
            else
            {

                while (a.next != tail)
                {
                    a = a.next;
                }
                tail = a;

                a.next = null;
                a = null;

                size--;
            }
        }
    }
}
