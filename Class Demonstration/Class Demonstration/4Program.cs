using System;

namespace Class_Demonstration
{
    /*Create a class with a handful of properties and a 
     * single constructor that has default values for all 
     * but one of the properties. Make sure that each 
     * property only accepts a restricted range of 
     * values. In your comments tell what ranges you 
     * properties accept
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Teenager
    {

        

        private int _age; //restricted age is 13 - 19

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
        private int _grade; // grade level is restricted to 6 - 12

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

        private double _gpa; // gpa is restricted to be between 0 and 4

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
            _age = age;
            _grade = grade;
            _gpa = gpa;
        }








    }

    
}
