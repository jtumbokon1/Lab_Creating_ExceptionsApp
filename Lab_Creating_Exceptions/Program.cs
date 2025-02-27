namespace Lab_Creating_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void MakeCircle(double radius)
            {
                try
                {
                    Circle circle = new Circle(radius);
                    Console.WriteLine(circle.ToString());
                }
                catch (InvalidRadiusException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MakeCircle(25);
            MakeCircle(-20);
            MakeCircle(20);
            MakeCircle(10);
            MakeCircle(0);
        }
    }//class
}//namespace
