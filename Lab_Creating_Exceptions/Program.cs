/*
 * CPRG-211-C Lab Creating Exceptions
 * Author: Jirch Tumbokon
 * When: Winter 2025
 */

/*
 * This program demonstrates creating and using custom exceptions
 * by creating a custom exception class called InvalidRadiusException
 * and using it in the Circle class to throw exceptions when an invalid
 * input is given for the radius of a circle.
 */

namespace Lab_Creating_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void MakeCircle(double radius)
            {
                //try to create a Circle object with the given radius
                try
                {
                    Circle circle = new Circle(radius);
                    Console.WriteLine(circle.ToString());
                }
                //catch InvalidRadiusException if radius is invalid and display its message
                catch (InvalidRadiusException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            //call MakeCircle with different radii
            MakeCircle(25);
            MakeCircle(-20);
            MakeCircle(20);
            MakeCircle(10);
            MakeCircle(0);
        }
    }//class
}//namespace
