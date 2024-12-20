namespace FunWithList
{
    //public delegate bool IsEven(int number);
    // Action
    // Func
    // Predicate
    internal class Program
    {
        static void Main(string[] args)
        {
            //Predicate<int> isEven = NumberIsEven;  

            List<int> ints = new List<int>();
            List<int> result = ints.FindAll(NumberIsEven);
        }

        static bool NumberIsEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
