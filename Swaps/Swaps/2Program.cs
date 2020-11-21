using System;

namespace Swaps
{
    class Program
    {

        /* Problem 2:

        Create a Method that accepts two integers and returns the integer result of “firstArg / secondArg”.

        Also swap the values of the arguments so that the method calling this one will be affected.

        Any exception needs to be caught by the method which will then return ‘0’.

        */



        static void Main(string[] args)
        {
            Console.WriteLine(Division(10, 5));
            Console.WriteLine(Division(5, 10)); // returns 0 because 5/10 is .5
            Console.WriteLine(Division(10, 0)); 
            Console.WriteLine(Division(657489, 5)); 

           
        }
        static int Division(int firstArg, int secondArg)
        {
            int answer;

            try 
            {
                answer = firstArg / secondArg;
            }
            catch (Exception) // if an excepetion is caught, then program will display a 0.
            {

                return 0;
            }

            return answer;
        }
        
    }
}
