using System.Collections;

namespace task2
{
    class MyCollection : IEnumerable, IEnumerator
    {
        private int[] myArray;
        private int position = -1;

        public MyCollection(int[] array)
        {
            myArray = array;
        }

        public object Current
        {
            get => myArray[position];
        }

        public bool MoveNext()
        {
            while (position < myArray.Length - 1)
            {
                position++;
                if (myArray[position] % 2 == 0 && myArray[position] != 0)
                    return true;

            }
            Reset();
            return false;
        }

        public void Reset() =>
            position = -1;
        
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }
}
