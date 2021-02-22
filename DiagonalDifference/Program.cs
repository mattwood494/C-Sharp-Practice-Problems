﻿using System.CodeDom.Compiler;
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
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                leftSum += arr.ElementAt(i).ElementAt(i);
                rightSum += arr.ElementAt(i).ElementAt(arr.Count - (1 + i));
            }

            return Math.Abs(leftSum - rightSum);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);

            
        }
    }
}
