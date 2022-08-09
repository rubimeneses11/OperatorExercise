using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //create two integer variables
            var a = 17;
            var b = 4;

            //create two more integer variables
            var quotient = a / b;
            var remainder = a % b;

            //use an if statement
            if (a == 17 && b == 4) ;

            //write out results as 17/4 is 4 remainder 1
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            //EXERCISE TWO-
            //allowing user input
            Console.WriteLine("Please enter the radius of your circle");
            var userInput = Console.ReadLine();

            var radius = double.Parse(userInput);

            //calling the method
            Console.WriteLine(AreaOfCircle(radius));
        }

        //EXERCISE TWO: create a method that will calculate the area of a circle based on its radius
        //declaring the AreaofCircle method
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}

