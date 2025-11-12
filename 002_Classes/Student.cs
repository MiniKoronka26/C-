namespace _003_Classes
{
    class Student
    {
        private string name;
        private string surname;
        private int age;

        public string Get_name()
        {
            return name;
        }
        public void Set_name(string name)
        {
            this.name = name;
        }
        public string Get_surname()
        {
            return name;
        }
        public void Set_surname(string surname)
        {
            this.surname = surname;
        }
        public int Get_age()
        {
            return age;
        }
        public void Set_age(int age)
        {
            this.age = age;
        }

        public Student() 
            : this("no set name", "no set surname", 0)
        {
        }

        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"name: {name} | surname: {surname} | age: {age}"); 
        }

        
                
                
                
                
                
                
                

                
                
                
                
    }
}
