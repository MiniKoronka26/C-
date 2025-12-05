using System.Collections;

namespace _008_StandartInterfaces
{
    class AuditoryEnumerator : IEnumerator
    {
        int pos = -1;
        Student[] students = null;
        public int Length
        {
            get { return students.Length; }
        }

        public AuditoryEnumerator(Student[] students)
        {
            this.students = students;
        }

        public object Current
        {
            get
            {
                return students[pos];
            }
        }

        public bool MoveNext()
        {
            if (pos < students.Length - 1)
            {
                pos++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
