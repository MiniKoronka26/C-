namespace _009_Generics
{
    class MyClass<T>
    {
        T a;

        public MyClass()
        {
            a = default;
        }
        public MyClass(T a)
        {
            this.a = a;
        }

        public T A
        {
            get { return a; }
            set { a = value; }
        }
        public override string ToString()
        {
            return $"a: {a}";
        }
    }
}
