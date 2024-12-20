using System;

namespace SimpleMath
{
    //public delegate T MathOperation<T>(T a, T b);
    //public delegate void Action<>
    // Action => built-in delegate type that takes 0 to 16 parameters and does not return a value
    // Func => built-in delegate type that takes 0 to 16 parameters and returns a value

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            //int result = calculator.Add(10, 20);
            //Console.WriteLine(result);

            //MathOperation<int> math = new MathOperation<int>(calculator.Add);
            //MathOperation<double> math2 = new MathOperation<double>(calculator.Add);
            Action<string> action = new Action<string>(PrintMessage);
            Action<int,int> action2 = new Action<int, int>(AddTwoNumbers);
            Func<int, int, int> func = new Func<int, int, int>(calculator.Add);
            Func<double, double, double> func2 = new Func<double, double, double>(calculator.Add);


            //action("this is message");
            //func2(10,20);


        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void AddTwoNumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
