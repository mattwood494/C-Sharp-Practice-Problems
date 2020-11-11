using System;

namespace Defining_Grade
{
    class Program
    {

        /*Write a program that will accept a grade of 0 - 100 and displays the correct Letter 
         * grade based on This course’s syllabus. (97-100 => A+, …)
         * 
         * 
        */


        static void Main(string[] args)
        {
            //Call the method
            DisplayLetterGrade(96);
        }

        static void DisplayLetterGrade(int percentage)
        {
            //Test to see what range the input falls into and display the correlated letter grade    
            if (percentage > 100)
            {
                Console.WriteLine("What?! Over 100?!?!?!");
            }
            else if (percentage >= 97 && percentage <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (percentage >= 93 && percentage <= 96)
            {
                Console.WriteLine("A");
            }
            else if (percentage >= 90 && percentage <= 92)
            {
                Console.WriteLine("A-");
            }
            else if (percentage >= 87 && percentage <= 89)
            {
                Console.WriteLine("B+");
            }
            else if (percentage >= 83 && percentage <= 86)
            {
                Console.WriteLine("B");
            }
            else if (percentage >= 80 && percentage <= 82)
            {
                Console.WriteLine("B-");
            }
            else if (percentage >= 77 && percentage <= 79)
            {
                Console.WriteLine("C+");
            }
            else if (percentage >= 73 && percentage <= 76)
            {
                Console.WriteLine("C");
            }
            else if (percentage >= 70 && percentage <= 72)
            {
                Console.WriteLine("C-");
            }
            else if (percentage >= 67 && percentage <= 69)
            {
                Console.WriteLine("D+");
            }
            else if (percentage >= 63 && percentage <= 66)
            {
                Console.WriteLine("D");
            }
            else if (percentage >= 60 && percentage <= 62)
            {
                Console.WriteLine("D-");
            }
            else if (percentage >= 0 && percentage <= 59)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Whoa...");
            }
            
            
        }
    }
}
