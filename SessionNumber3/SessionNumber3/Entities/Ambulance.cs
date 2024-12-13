using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Entities
{
    internal class Ambulance : Vehicle
    {

        public void CanTreatPatiants()
        {
            Console.WriteLine("Start Treating patiants");
        }

        public override void StartEngine()
        {
            Console.WriteLine("Inject Fuel");
            Console.WriteLine("Warm up the medical tools");
            Console.WriteLine("Start Engine");
        }
    }
}
