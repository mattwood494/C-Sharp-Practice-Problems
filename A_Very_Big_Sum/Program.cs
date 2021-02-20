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

namespace A_Very_Big_Sum
{
    /*
    *  
    *  In this challenge, you are required to calculate and print the sum of the elements in an array, keeping in mind that some of those integers may be quite large.

    Function Description

    Complete the aVeryBigSum function in the editor below. It must return the sum of all array elements.

    aVeryBigSum has the following parameter(s):

    int ar[n]: an array of integers .
    Return

    long: the sum of all array elements
    Input Format

    The first line of the input consists of an integer .
    The next line contains  space-separated integers contained in the array.

    Output Format

    Return the integer sum of the elements in the array.

    Constraints
    1 <= n <= 10
    0 <= ar[i] <= 10^10

     */
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (int num in ar)
            {
                sum += num;
            }

            return sum;

        }

        static void Main(string[] args)
        {
            long[] numbers = new long[] { 55432, 5432542, 5432432, 5436 };
            Console.WriteLine(aVeryBigSum(numbers));
        }
    }
}
