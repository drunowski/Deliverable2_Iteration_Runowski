//Author: David Runowski
//Date: 01/30/2020

using System;

namespace Deliverable2_Iteration_Runowski
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for an input
            Console.WriteLine("Please Enter an Integer between 1 and 100...");
            try
            {
                //Store input from user into variable
                string input = Console.ReadLine();
                //cast input variable to an integer
                int x = int.Parse(input);
                //define count variable
                int count = 1;

                //create loop with conditon that count must be less than or equal to x
                while(count <= x)
                {
                    //write line for each iteration
                    Console.WriteLine("You have entered " + x + ". This is the current integer value in the loop: " + count);
                    count++; //add 1 to count with each iteration
                }
            }
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}
