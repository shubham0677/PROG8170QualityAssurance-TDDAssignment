using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void AddToRadius(double input)
        {
            Radius += input;
        }
    }
}
