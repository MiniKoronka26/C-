using System.Collections;

namespace _009_Vector_Generics
{
    class Vector<T> : IEnumerable
    {
        T[] mass;
        int count = 0;
    
        public int Count { get; set; }
    
        public Vector()
        {
            mass = new T[0];
        }
    
        public Vector(T[] mass)
        {
            this.mass = mass;
            this.count = mass.Length;
        }
        public void PushBack(T value)
        {
            T[] newMass = new T[count + 1];
    
            for (int i = 0; i < count; i++)
                newMass[i] = mass[i];
    
            newMass[count] = value;
            mass = newMass;
    
            count++;
        }
    
        public void PopBack()
        {
            if (count == 0)
            {
                throw new Exception("Vector is empty");
            }
    
            count--;
        }
    
        public void Insert(int index, T value)
        {
            if (index < 0 || index > count)
            {
                throw new Exception("Index out of range");
            }
    
            if (count == mass.Length)
            {
                T[] newMass = new T[count + 1];
                for (int i = 0; i < count; i++)
                {
                    newMass[i] = mass[i];
                }
    
                mass = newMass;
            }
    
            for (int i = count; i > index; i--)
            {
                mass[i] = mass[i - 1];
            }
    
            mass[index] = value;
            count++;
        }
    
        public void Erase(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new Exception("Index out of range");
            }
    
            for (int i = index; i < count - 1; i++)
            {
                mass[i] = mass[i + 1];
            }
            count--;
        }
    
        public bool isEmpty()
        {
            return count == 0;
        }
    
        public T At(int index)
        {
            if (index >= 0 && index < count)
            {
                return mass[index];
            }
            throw new Exception("Index out of range");
        }
    
        public void Reverse()
        {
            for (int i = 0; i < count / 2; i++)
            {
                T temp = mass[i];
                mass[i] = mass[count - i - 1];
                mass[count - i - 1] = temp;
            }
        }
    
        public void Clear()
        {
            count = 0;
        }
    
        public override string ToString()
        {
            if (count == 0)
                return "Vector is Empty";
    
            string result = "Vector array: ";
            for (int i = 0; i < count; i++)
            {
                result += mass[i] + ", ";
            }
            return result;
        }

        public IEnumerator GetEnumerator()
        {
           return new VectorEnumerator<T>(mass);
        }

        public T this[int index]
        {
            get
            {
                return At(index);
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    throw new Exception("Index out of range");
                }
                mass[index] = value;
            }
        }
    }
}
