using System;

namespace OperatorExercise
{
    class MainClass
    {
        // Method called here will be used below 

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);

        }

        public static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;
            var j = 4;
            var i = 3;
            var k = ++i * j++;

            Console.WriteLine($"{a}/{b} is { div} remainder {mod} and K is equal to {k}");

            Console.WriteLine("What is the radius of your circle?");

            //  The line below makes the user enter a value for the radius
            var radius = double.Parse(Console.ReadLine()); 

            // this line calculates the area based on the method above and the radius entered above                                           
            var areaOfCircle = CalculateArea(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is {areaOfCircle}");





        }

        


    }
}
