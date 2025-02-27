using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    public class InvalidRadiusException : Exception
    {
        //A constructor that accepts one double parameter radius and passes to the base class constructor a message $"Invalid radius {radius}: must be non-negative"
        public InvalidRadiusException(double radius) : 
            base($"Invalid radius {radius}: must be non-negative")
        {
        }
        //A constructor that accepts two double parameters: radius and maxRadius, and passes to the base class constructor a message $"Invalid radius {radius}: must be between 0 and {maxRadius}"
        public InvalidRadiusException(double radius, double maxRadius) : 
            base($"Invalid radius {radius}: must be between 0 and {maxRadius}")
        {
        }
    }
}
