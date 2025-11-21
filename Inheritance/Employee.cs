namespace _006_Inheritance
{
    class Employee : Person
    {
        public Employee(string name, int age, double salary) : base(name, age)
        {
            Salary = salary;
        }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Salary: {Salary}";
        }
    }
}
