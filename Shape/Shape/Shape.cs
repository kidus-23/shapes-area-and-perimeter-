using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
  abstract class Shape
    {
        public abstract double getArea();
        public abstract double getPerimeter();
    }
    interface Shape1
    {
        public double getArea();
        public double getPerimeter();
    }
}
