using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Creating_Exceptions
{
    public class InvalidRadiusException : Exception
    {
        // constructors
        public InvalidRadiusException(double radius) : 
            base($"Invalid radius {radius}: must be non-negative")
        {

        }
        public InvalidRadiusException(double radius, double maxRadius) : 
            base($"Invalid radius {radius}: must be between 0 and {maxRadius}")
        {
        }
    }//class
}//namespace
