using System;

namespace TestClass
{
    /*
     * Problem 5:

        Create a Test project that tests the ranges of the 
        previous class to ensure it only accepts values in the 
        given ranges
     */
    class Program
    {
        static void Main(string[] args)
        {
            Teenager joe = new Teenager(99, 543, 200);
            Console.WriteLine(joe.Age);
            Console.WriteLine(joe.Grade);
            Console.WriteLine(joe.GPA);

            Console.WriteLine();
            Console.WriteLine();

            Teenager bob = new Teenager(18, 9, 3.29);
            Console.WriteLine(bob.Age);
            Console.WriteLine(bob.Grade);
            Console.WriteLine(bob.GPA);


        }
    }

    public class Teenager
    {



        private int _age = -1; //restricted age is 13 - 19

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 20 && value > 12)
                {
                    _age = value;
                }

            }
        }

        public string _school { get; set; } //school value is unrestricted
        private int _grade = -1; // grade level is restricted to 6 - 12

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value > 6 && value < 12)
                {
                    _grade = value;
                }

            }
        }

        private double _gpa = -1.0; // gpa is restricted to be between 0 and 4

        public double GPA
        {
            get { return _gpa; }
            set
            {
                if (value >= 0 && value <= 4)
                {
                    _gpa = value;
                }

            }
        }

        public Teenager(int age, int grade, double gpa)
        {
            Age = age;
            Grade = grade;
            GPA = gpa;
        }








    }
}
