using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Entities
{
    internal abstract class Vehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int NumberOfCC { get; set; }
        protected int numberOfWindows { get; set; }

        public Vehicle()
        {
            
        }
        public Vehicle(int wheels,string color,int numberofcc) {
            if (wheels > 5)
            {
                wheels = 4;
            }
            else
            {
                this.Wheels = wheels;

            }
            this.Color = color;
            this.NumberOfCC = numberofcc;
        }

        public abstract void StartEngine();

        public void StopEngine() {
            Console.WriteLine("Engine Stopped");
        }
    }
}
