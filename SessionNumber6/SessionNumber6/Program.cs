namespace SessionNumber6
{
    public delegate string MyDelegate(string message);

    internal class Program
    {
        // Delegate => is a type that acts as a reference to a method
        /*
         * 1- The method defination
         * 2- the method return type
         * 3- the method parameters
         * What happens when you define a delegate?
         * 
         * 1- create sealed class that inherits
         * from System.MulticastDelegate
         *  1- Invoke method
         *  2- BeginInvoke method (deprecated)
         *  3- EndInvoke method (deprecated)
         * 
         */
        static void Main(string[] args)
        {
            MyDelegate instance = delegate (string message)
            {
                Console.WriteLine("To upper");
                return message.ToUpper();
            };

            instance += delegate (string message) 
            {
                Console.WriteLine("To lower");
                return message.ToLower();
            };

            string result = instance.Invoke("this is a message from the delegate");
            
            Console.WriteLine(result);
            //instance.BeginInvoke("this is a message from the delegate", null, null);
        }
    }
}
