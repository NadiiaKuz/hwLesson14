using System.Collections;

namespace task2
{
    class MyCollection : IEnumerable<int>
    {
        int[] myArray;

        public MyCollection(int[] array) =>
            myArray = array;

        public IEnumerator<int> GetEnumerator() =>
            new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() =>
            new Enumerator(this);

        class Enumerator : IEnumerator<int>
        {
            int position = -1;

            MyCollection collection;

            internal Enumerator(MyCollection collection) =>
                this.collection = collection;

            public int Current =>
                collection.myArray[position];

            object IEnumerator.Current => 
                Current; 

            public bool MoveNext()
            {
                while (position < collection.myArray.Length - 1)
                {
                    position++;
                    if (collection.myArray[position] % 2 == 0 && collection.myArray[position] != 0)
                        return true;

                }

                Reset();
                return false;
            }

            public void Reset() =>
                position = -1;

            public void Dispose() { }
        }
    }
}