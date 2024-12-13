using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Entities
{
    internal class ElectricCar : Car
    {
        public override void StartEngine()
        {
            //base.StartEngine();
            Console.WriteLine("Start Battery");
            Console.WriteLine("Start Engine");
        }
    }
}
