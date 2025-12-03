namespace _009_UserCollections
{
    class Element
    {
        public string Name { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }

        public Element(string name, int field1, int field2)
        {
            this.Name = name;
            this.Field1 = field1;
            this.Field2 = field2;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Flield1: {Field1}, Field2: {Field2}";
        }
    }
}
