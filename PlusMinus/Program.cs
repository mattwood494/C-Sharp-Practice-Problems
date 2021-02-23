using System;
using System.Collections.Generic;

namespace PlusMinus
{
    class Program
    {
        /*Given an array of integers, calculate the ratios of its elements that
         * are positive, negative, and zero. Print the decimal value of each 
         * fraction on a new line with 6 places after the decimal.
         */
        static void plusMinus(int[] arr)
        {
            List<float> converted = new List<float>(); //Will store the array parameter in float form
            List<float> positives = new List<float>(); //will store all positive numbers
            List<float> negatives = new List<float>(); //will store all negatives
            List<float> zero = new List<float>();  // and all zeros

            
            foreach (int num in arr)
            {
                converted.Add(num);
            }
            float count = converted.Count;


            foreach (float num in converted)
            {

                if (num > 0)
                {
                    positives.Add(num);
                }
                else if (num < 0)
                {
                    negatives.Add(num);
                }
                else
                {
                    zero.Add(num);
                }
            }

            Console.WriteLine(positives.Count / count);
            Console.WriteLine(negatives.Count / count);
            Console.WriteLine(zero.Count / count);




        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
