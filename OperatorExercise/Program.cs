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
        }
    }
}

