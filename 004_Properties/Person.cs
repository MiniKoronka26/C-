namespace _004_Properties
{
    class Person
    {
        string lastName;
        /*int age;

        public int Age
        {
            get
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }*/

        public int Age {  get; set; }

        /*public void Set_last_name(string lastName)
        {
            this.lastName = lastName;
        }

        public string Get_last_name()
        {
            return this.lastName;
        }*/

        public string LastName { 
            get {
                return lastName; 
            }
            set
            {
                if(value.Length > 2) 
                    lastName = value;
            }
        }

    }
}
