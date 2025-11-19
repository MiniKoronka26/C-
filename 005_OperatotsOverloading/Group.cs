namespace _005_OperatotsOverloading
{
    class Group
    {
        Student[] students;
        public Group(Student[] students)
        {
            this.students = students;
        }

        public override string ToString()
        {
            return string.Join("\n", students.Select(s => s.ToString()).ToArray());
        }

        public Student this[int index]
        {

            get { return students[index]; }
            set
            {
                if (index >= 0 && index < this.students.Length)
                    students[index] = value;
            }
        }

        public int Find_index_by_name(string name)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Name == name)
                    return i;
            }
            return -1;
        }

        public Student this[string name]
        {

            get
            {
                int index = Find_index_by_name(name);
                return students[index];
            }
            set
            {
                int index = Find_index_by_name(name);
                if (index != -1)
                    students[index] = value;
            }
        }
    }
}
