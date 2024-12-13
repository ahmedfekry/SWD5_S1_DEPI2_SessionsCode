using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionNumber3.Shapes
{
    internal class Square : Shape
    {
        public int Width { get; set; }

        public override double GetArea()
        {
            return this.Width * this.Width;
        }
    }
}
