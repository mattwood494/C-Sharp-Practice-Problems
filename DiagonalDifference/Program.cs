using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace DiagonalDifference
{

    /*Given a square matrix, calculate the absolute difference between the sums
     * of its diagonals.
     */

    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */


        //A list of lists is the input and diagonalDifference will return an int
        //representing the difference between the diagonals
        public static int diagonalDifference(List<List<int>> arr) 
        {
            int leftSum = 0; //sum of the left diagonal
            int rightSum = 0; //sum of the right diagonal

            //for loop adds the integers at the appropriate coordinate to its respective list
            for (int i = 0; i < arr.Count; i++)
            {
                leftSum += arr.ElementAt(i).ElementAt(i); //adding integer at appropriate coordinates to leftSum
                rightSum += arr.ElementAt(i).ElementAt(arr.Count - (1 + i)); //adding integer at appropriate coordinates to rightSum
            }

            return Math.Abs(leftSum - rightSum); //returning the absolute of the difference of leftSum and rightSum
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            //n represents the number of rows and columns in the square matrix
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            //instantiating the list of list square matrix
            List<List<int>> arr = new List<List<int>>();

            //takes the integer inputs from the user that will make up the square matrix
            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            //stores the difference between diagonals in reult
            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

            
        }
    }
}
