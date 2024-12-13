using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Shapes
{
    internal abstract class Shape
    {
        public string Color { get; set; }

        public abstract double GetArea();
        public void DisplayInfo()
        {
            Console.WriteLine($"This shape has color {Color}"); 
        }
    }
}
