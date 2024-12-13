
namespace SessionNumber3
{
    /* Encapsulation (Access Modifiers)
     *  1- public -> can be access from inside the class and from any object from the class
     *  2- private -> can be accessed from inside the class only
     *  3- protected -> just like the private by can be access from the drived classes
     *  4- internal -> class can be accessed withen the same project only
     * 
     * 
     * 
     * 
     * 
     * 
     */
    public class CarOld
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        protected string SerialNumber { get; set; }

        public static int NumberOfWheels = 4;

        // defualt constructor (has no parameters)
        // can only contain one default ctor

        public CarOld()
        {

        }

        // paramterized constructor
        public CarOld(int id, string name) : this(id,name,"","")
        {
        }


        public CarOld(int id,string name,string color) : this(id,name,color,"")
        {

        }

        public CarOld(int id,string name,string color, string serialnumber)
        {

            this.Id = id;
            if (name.Length > 20)
            {
                name = name.Substring(0, 20);
            }
            else
            {
                this.Name = name;
            }
            this.Color = color;
            Console.WriteLine("This is the ctor with three params");
        }

        public void CanRun()
        {
            //Console.WriteLine(this.SerialNumber);
            Console.WriteLine($"I can Run on {NumberOfWheels} wheels");
        }

        public static string[] configs = {"value 1","value 2"};
        static CarOld()
        {
            configs[0] = "value 1";
            configs[1] = "Value 2";
        }

        static void MethodTest()
        {
            Console.WriteLine("sdfsdf");
        }
        public string CanBreak()
        {
            MethodTest();
            Console.WriteLine(this.Name);
            Console.WriteLine(this.SerialNumber);
            return "I can Break on the road";
        }
    }
}
