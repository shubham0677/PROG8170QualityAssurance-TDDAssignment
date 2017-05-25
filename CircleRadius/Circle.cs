using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    public class Circle
    {
        private const double pi = 3.14;
        public double Radius { get; set; }

        public Circle()
        {
            
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void AddToRadius(double num)
        {
            if(num < 0)
            {
                return;    
            }

            Radius += num;
        }

        public void SubtractFromRadius(double num)
        {
            if(Radius - num < 0)
            {
                return;
            }

            Radius -= num;
        }

        public double GetCircumference()
        {
            double circumference = 2 * pi * Radius;
            return Math.Round(circumference, 1);
        }
    }
}
