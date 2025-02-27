using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    public class Circle
    {
        private double radius;
        private const double MAX_RADIUS = 20;

        //constructor
        public Circle(double newRadius)
        {
            //if radius is within range , set it to newRadius
            if (newRadius >= 0 && newRadius <= MAX_RADIUS)
            {
                radius = newRadius;
            }
            //if radius is negative, throw InvalidRadiusException with newRadius
            else if (newRadius < 0)
            {
                throw new InvalidRadiusException(newRadius);
            }
            //if radius is out of range, throw InvalidRadiusException with newRadius and MAX_RADIUS
            else
            {
                throw new InvalidRadiusException(newRadius, MAX_RADIUS);
            }
        }
        public override string ToString()
        {
            return $"Circle[radius={radius}]";
        }
    }//class
}//namespace
