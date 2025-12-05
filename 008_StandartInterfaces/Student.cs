namespace _008_StandartInterfaces
{
    class Student : IComparable, ICloneable

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            Student student = (Student)this.MemberwiseClone(); // не глибоке клонування
            //student.StudentCard = new StudentCard
            //{
            //    Number = this.StudentCard.Number,  
            //    Series = this.StudentCard.Series,
            //};
            student.StudentCard = (StudentCard)this.StudentCard.Clone(); // глибоке клонування
            return student;

        }

        public int CompareTo(object? obj)
        {
            if ((obj is Student))
            {
                Student other = (obj as Student);
                return other.FirstName.CompareTo(this.FirstName);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Student: {FirstName}, {LastName} {BirthDate.ToShortDateString()} {StudentCard}";
        }
    }
}
