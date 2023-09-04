using System.Collections;

namespace task1_Yield
{
    class MyCollection : IEnumerable<int>
    {
        private int[] myArray;
        private int position = 0;

        public MyCollection(int[] array)
        {
            myArray = array;
        }

        public IEnumerator<int> GetEnumerator()
        {
            while (position < myArray.Length - 1)
            {
                if (myArray[position] % 2 == 0 && myArray[position] != 0)
                    yield return myArray[position];

                position++;
            }    
            
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
