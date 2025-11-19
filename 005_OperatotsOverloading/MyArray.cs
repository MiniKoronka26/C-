namespace _005_OperatotsOverloading
{
    class MyArray
    {
        MyArray(int[] arr)
        {
            this.Arr = arr;
        }
        public MyArray() { }

        public int[] Arr { get; set; }
        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.Arr));
        }

        public int Length
        {
            get { return this.Arr.Length; }
        }

        public int this[int index]
        {

            get { return Arr[index]; }
            set 
            {
                if (index >= 0 && index < this.Arr.Length)
                    Arr[index] = value; 
            }
        }

    }
}
