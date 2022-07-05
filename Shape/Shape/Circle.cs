using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        public double r { get; set; }

        public override double getArea()
        {
            return 3.14 * r * r;
        }
        public override double getPerimeter()
        {
            return 2 * 3.14 * r;
        }
    }
}
