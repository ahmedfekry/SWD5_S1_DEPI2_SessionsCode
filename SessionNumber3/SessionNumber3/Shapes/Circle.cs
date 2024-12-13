using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
