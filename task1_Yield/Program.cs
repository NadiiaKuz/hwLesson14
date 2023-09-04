
namespace task1_Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            MyCollection myCollection = new(array);

            foreach (int i in myCollection)
            {
                Console.WriteLine(i);
            }
        }
    }
}