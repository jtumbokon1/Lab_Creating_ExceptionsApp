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
            //If the newRadius is within the valid range, the constructor sets the radius to be the newRadius value.  
            if (newRadius > 0 && newRadius <= MAX_RADIUS)
            {
                radius = newRadius;
            }
            //If the newRadius is negative, the constructor throws the exception InvalidRadiusException passing to it one argument: newRadius. 
            else if (newRadius < 0)
            {
                throw new InvalidRadiusException(newRadius);
            }
            //If the newRadius is greater than MAX_RADIUS, the constructor throws the exception InvalidRadiusException passing to it two arguments: newRadius and MAX_RADIUS.
            else
            {
                throw new InvalidRadiusException(newRadius, MAX_RADIUS);
            }
        }
        public string ToString()
        {
            return $"Circle[radius={radius}]";
        }
    }
