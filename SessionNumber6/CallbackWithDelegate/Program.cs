using System.Runtime.CompilerServices;

namespace CallbackWithDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("John", 60, 100);
            int NumberOfEventsRaised = 0;
            //NotifyDriverDelegate about 
            //    = new NotifyDriverDelegate(CarAboutToExplode);

            //NotifyDriverDelegate exploded
            //    = new NotifyDriverDelegate(CarExploded);

            car.CarExpoloded += delegate(object obj,CarEventArgs args)
            {
                NumberOfEventsRaised++;
                Console.WriteLine("====== Danger====== ");
                if (obj is Car c)
                {
                    Console.WriteLine($"Run {c.DriverName}, " + args.Message);
                }
                Console.WriteLine("=================== ");
            };

            car.CarAboutToExplode += delegate(object obj,CarEventArgs args)
            {
                NumberOfEventsRaised++;
                Console.WriteLine("====== Warning====== ");
                if (obj is Car c)
                {
                    Console.WriteLine($"Take care , {c.DriverName} " + args.Message);
                }
                Console.WriteLine("===================== ");
            };


            for (int i=0; i<10; i++) { 
                car.Accelerate(10);
            }

            Console.WriteLine($"Number of events raised: {NumberOfEventsRaised}");
        }

        //public static void CarAboutToExplode(object obj,CarEventArgs args)
        //{
            
        //}   

        //public static void CarExploded(Object obj, CarEventArgs args)
        //{
           
        //}
    }
}
