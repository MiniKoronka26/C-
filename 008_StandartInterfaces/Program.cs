using _008_StandartInterfaces;

/*Auditory auditory = new Auditory();

Console.WriteLine(new string('+', 10) + " список студентів " + new string('+', 10) + "\n");
for (int i = 0; i < auditory.Length; i++)
{
    Console.WriteLine(auditory[i]);
}

Console.WriteLine();

auditory.Sort();
Console.WriteLine(new string('+', 10) + " список студентів посортованих автоматично " + new string('+', 10) + "\n");

for (int i = 0; i < auditory.Length; i++)
{
    Console.WriteLine(auditory[i]);
}

Console.WriteLine();

auditory.Sort(new StudentBithdayComparer());
Console.WriteLine(new string('+', 10) + " список студентів посортованих за днем народження " + new string('+', 10) + "\n");

for (int i = 0; i < auditory.Length; i++)
{
    Console.WriteLine(auditory[i]);
}*/

/*StudentCard studentCard1 = new StudentCard
{
    Number = 1234,
    Series = "ABC1234"
};

StudentCard studentCard2 = (StudentCard)studentCard1.Clone();
studentCard2.Number = 9999;
Console.WriteLine(studentCard1);
*/

/*Student student1 = new Student
{
    FirstName = "John",
    LastName = "Miller",
    BirthDate = new DateTime(1997, 3, 12),
    StudentCard = new StudentCard
    {
        Number = 189356,
        Series = "AB"
    }
};

Student student2 = (Student)student1.Clone();
student2.FirstName = "AAAAAAA";
student2.StudentCard.Number = 9999;
Console.WriteLine(student1);*/

Auditory auditory = new Auditory();

foreach (Student student in auditory)
{
    Console.WriteLine(student);
}

