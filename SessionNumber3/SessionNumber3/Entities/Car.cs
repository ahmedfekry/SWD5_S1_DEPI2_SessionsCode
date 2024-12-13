using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Entities
{
    internal class Car : Vehicle
    {

        public Car() { }
        public Car(string color,int numberofcc) : base(0,color,numberofcc) {
            this.numberOfWindows = 5;
        }

        public override void StartEngine()
        {
            Console.WriteLine("inject feul") ;
            Console.WriteLine("Start Engine");
        }
    }
}
