using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : Shape
    {
        public double l { get; set; }
        public double w { get; set; }

        public override double getArea()
        {
            return l * w;
        }
        public override double getPerimeter()
        {
            return 2 * l * 2 * w;
        }
    }
}
