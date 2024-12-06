using System.Runtime.Serialization;

namespace SessionNumber2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            //int[] array = new int[5];
            //array[0] = 10;
            //array[1] = 12;
            //array[2] = 3;
            //array[3] = 45;
            //array[4] = 5;



            //string firstName = "Ahmed";
            //string lastName = "Fekry";

            //string welcomeMessage = @$"ljkkjhdkfjghdfg
            //                            kjljkshkjdhfkjshdkf
            //                             {firstName} {lastName}";

            //Console.WriteLine(welcomeMessage);
            // Loops
            //1- For
            string[] array = { "ahmed", "aly", "Mohamed", "sdfssdf", "sdfsdfsdf" };

            //initialazation ; condifiton; increament
            //for (int i = 0; i <= array.Length;i++)
            //{
            //    if (i == 2)
            //    {
            //        break;
            //    }
            //    Console.WriteLine($"Element at index {i} has the value {array[i]}");
            //}

            //2- for each loop

            //foreach(string s in array)
            //{
            //    Console.WriteLine(s);
            //}

            //3- While loops
            //int i = 0;
            //while(i < array.Length)
            //{

            //    if (i == 1)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(array[i]);
            //    i++;
            //}
            //int i = 1;
            //while(i <= 100)
            //{
            //    if (i%2 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Console.WriteLine(10 % 2);

            // If condition
            //int age = 10;
            //if( age >= 16)
            //{
            //    Console.WriteLine("You should have a valid national id");
            //}
            //else if(age > 10 && age < 16)
            //{
            //    Console.WriteLine("you still a teenger");
            //}
            //else
            //{
            //    Console.WriteLine("Go home and drink some milk");
            //}
            //string message = (age >= 16) ? "You should have a valid national id" 
            //                             : (age > 10 && age < 16) ? "you still a teenger" 
            //                             : "Go home and drink some milk";
            //(condition) ? true : false;

            //Console.WriteLine(message);

            //string day = Console.ReadLine();

            //switch (day)
            //{
            //    case "Saturday": Console.WriteLine(1); break;
            //    case "Sunday": Console.WriteLine(2); break;
            //    case "Monday": Console.WriteLine(3); break;
            //    default: Console.WriteLine("Invalid day"); break;
            //}

            //do
            //{
            //    Console.WriteLine("This is a do while loop");
            //} while (1 == 2);

            //while (1 == 2)
            //{
            //    Console.WriteLine("this is a regular while loop");
            //}

            //Console.WriteLine("Enter the Width: ");
            //int x = int.Parse(Console.ReadLine());
            ////string str = Console.ReadLine();
            //Console.WriteLine("Enter the Height: ");
            //int y = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Enter the Radius: ");
                double radus = double.Parse(Console.ReadLine());

                double area = CalculateArea(radus);
                Console.WriteLine(area);
                //Test test = new Test(); 
                //Console.WriteLine(test.MyProperty.ToString());
            }
            catch(FormatException formatEx)
            {
                Console.WriteLine("=============Format Error Block===============");
                Console.WriteLine("You Entered string value which is wrong");
                Console.WriteLine(formatEx.Message);
                Console.WriteLine("==============================================");
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine("=============Null Error Block===============");
                Console.WriteLine("You are trying to access null value");
                Console.WriteLine(ex.Message);
                Console.WriteLine("==============================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine("=============Error Block===============");
                Console.WriteLine("The system has crashed");
                Console.WriteLine("Exception Message => " + ex.Message);
                Console.WriteLine("Exception Details => " + ex.StackTrace);
                Console.WriteLine("Exception Details => " + ex.ToString());
                Console.WriteLine("========================================");
            }
            finally
            {
                Console.WriteLine("=====================");
                Console.WriteLine("====Finally==========");
                Console.WriteLine("=====================");
            }

            //string? x = Console.ReadLine();

            //int? c = 10;
            //Console.WriteLine(c.Value);
            //int x = null;
            //Nullable<int> x = null;
            //string str = "Ahmed";

            //str != "sdfsdf";
            //Console.WriteLine(str);
            //int? x = null;

            //Console.WriteLine(str);
        }

        // Access Modifier , return_type, MethodName(params)

        static int CalculateArea(int width,int height)
        {
            return width* height;   
        }

        static double CalculateArea(double radius)
        {
            if (radius < 0)
            {
                throw new InvalidDataException("Radius can't be less then zero!!!!!");
            }
            return Math.PI*radius*radius;
        }

        static void Calculator(int number1,int number2,string oper)
        {

            if (oper == "+")
            {
                Console.WriteLine(number1 + number2);
            }
            else if (oper == "-")
            {
                Console.WriteLine(number1 - number2);
            }
            else if (oper == "*")
            {
                Console.WriteLine(number1 * number2);
            }
            else
            {
                Console.WriteLine(number1 / number2);
            }

        }
    }
}
