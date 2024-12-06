using NameSpca;
using System.IO;

namespace SessionNumber_Group2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //local 
            //    global
            testClass testClass1 = new testClass();
            testClass1.x = 10;

            testClass testClass2 = testClass1;

            testClass1.x = 100;

            Console.WriteLine(testClass2.x);
            //testFunction();

            //Console.WriteLine("Finished");

            /*
             * 
             * 1- value types
             * int,double,float,bool,char,struct
             * 
             *  a- types is assigned in the stack
             *  b- it is deleted from the stack when the variable is out of scope
             *  c- when assign variable to another to copies the value only 
             * 
             * 2- reference types
             * 
             *  string,array,class
             * 
             *  a- types is assigned in the heap with pointer (reference in the stack)
             * 
             * 
             */


        }

        static void testFunction()
        {
            string b = "Hello";
            Console.WriteLine(b);
        }
    }
}
