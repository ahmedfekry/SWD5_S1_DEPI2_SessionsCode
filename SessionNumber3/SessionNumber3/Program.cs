using SessionNumber3.Entities;
using SessionNumber3.Shapes;

namespace SessionNumber3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car mercides = new();
            //mercides.Id = 1;
            //mercides.Color = "Red";
            //mercides.Name = "Zooba";

            //Console.WriteLine(mercides.Name);
            //Console.WriteLine(mercides.Color);
            //Console.WriteLine(mercides.Id);
            //Console.WriteLine(Car.NumberOfWheels);
            //mercides.CanRun();
            //Car.NumberOfWheels = 10;
            //Console.WriteLine(mercides.CanBreak());
            //Console.WriteLine(Car.NumberOfWheels);
            //Console.WriteLine(Car.NumberOfWheels);

            //Console.WriteLine("======================");
            //Car bmw = new Car(2,"Sooso","Red");
            //Console.WriteLine(bmw.Name);
            //Console.WriteLine(bmw.Color);
            //Console.WriteLine(bmw.Id);
            //Console.WriteLine(Car.NumberOfWheels);
            //bmw.CanRun();

            //Console.WriteLine(bmw.CanBreak());

            //foreach (string s in CarOld.configs) {
            //    Console.WriteLine(s);
            //}


            //CarOld bmw = new CarOld(2, "Sooso", "Red");
            //Console.WriteLine(bmw.Name);
            //Console.WriteLine(bmw.Color);
            //Console.WriteLine(bmw.Id);
            //Console.WriteLine(CarOld.NumberOfWheels);

            //foreach (string s in CarOld.configs)
            //{
            //    Console.WriteLine(s);
            //}



            //Car car = new Car("red",1600);

            //car.StartEngine();
            //car.StopEngine();
            //car.NumberOfCC = 1600;
            //car.Wheels = 4;


            //Ambulance ambulance = new Ambulance();
            //ambulance.StartEngine();
            //ambulance.StopEngine();
            //ambulance.Wheels = 5;
            //ambulance.NumberOfCC = 200;
            //ambulance.CanTreatPatiants();

            //Vehicle electricCar = new ElectricCar();
            //electricCar.StartEngine();
            //electricCar.StopEngine();

            //Vehicle vehicle = new Vehicle();    

            Shape shape = new Square();
            shape.DisplayInfo();
            Console.WriteLine(shape.GetArea()) ;

            Shape cir = new Square();
            cir.DisplayInfo();
            Console.WriteLine(cir.GetArea());


            //if (electricCar is Ambulance)
            //{
            //    Console.WriteLine("Electric car is the child of vehicle");

            //}



            //int x = 10;
            //int y = 10;
            //Add(x,y);
        }

        static int Add(int x,int y)
        {
            return x + y;
        }

        static double Add(double x,double y)
        {
            return x + y;
        }
    }
}
