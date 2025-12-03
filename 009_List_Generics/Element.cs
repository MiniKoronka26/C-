namespace _009_List_Generics
{
    class Element<T>
    {
        public T Data { get; set; }
        public Element<T> next;
        public Element()
        {
            Data = default;
            next = null;
        }
        public Element(T data, Element<T> next)
        {
            this.Data = data;
            this.next = next;
        }
    }
}
