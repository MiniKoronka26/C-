using System.Collections;

namespace _009_Vector_Generics
{
    class VectorEnumerator<T> 
        : IEnumerator
    {
        int pos = -1;

        private T[] mass;
        private int count = 0;

        public VectorEnumerator(T[] mass)
        {
            this.mass = mass;
            count = mass.Length;
        }

        public object Current
        {
            get
            {
                return mass[pos];
            }
        }
        public bool MoveNext()
        {
            if (pos < mass.Length - 1)
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
