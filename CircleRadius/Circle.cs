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

        public bool AddToRadius(double num)
        {
            if(num < 0)
            {
                return false;    
            }

            Radius += num;
            return true;
        }

        public bool SubtractFromRadius(double num)
        {
            if(Radius - num < 0)
            {
                return false;
            }

            Radius -= num;
            return true;
        }

        public double GetCircumference()
        {
            if(Radius == 0.0)
            {
                throw new RadiusNotProvidedException();
            }

            double circumference = 2 * pi * Radius;
            return Math.Round(circumference, 1);
        }

        public double GetArea()
        {
            if (Radius == 0.0)
            {
                throw new RadiusNotProvidedException();
            }

            double area = pi * Math.Pow(Radius, 2);
            return Math.Round(area, 1);
        }
    }
}
