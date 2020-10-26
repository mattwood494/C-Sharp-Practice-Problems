using System;

namespace Two_Sum
{
    class Program
    {

        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        // You can return the answer in any order.

        // Example 1:
        //      Input: nums = [2,7,11,15], target = 9
        //      Output: [0,1]
        //      Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        
        //Example 2:
        //      Input: nums = [3,2,4], target = 6
        //      Output: [1,2]
        
        //Example 3:
        //      Input: nums = [3,3], target = 6
        //      Output: [0,1]

        // Assumptions
        //  Method will only accept number inputs
        // Method returns an array of integers
        // Each input would have exactly one input
        // I will only use the same element once
        // return of -1 means there was no match


        //Constraints:

        //      2 <= nums.length <= 105
        //      -109 <= nums[i] <= 109
        //      -109 <= target <= 109
        //      Only one valid answer exists.



        // Pseudocode
        /* 
         
        Create method that takes an array and returns an array
        
        Test each combination of numbers in nums to see if they add up to target by creating a loop inside of another loop
        Ensure that if the number in nums has the same index then skip testing that combination
        If two numbers do add up to target then create an array that includes the indices of the two numbers that add up to target


         */
        static void Main(string[] args)
        {
            int[] nums = { 3,3 }; //inputs
            int target = 6;

             int[] solution = TwoSum(nums, target);
            foreach (var item in solution) //print out solution to test if correct output was obtained
            {
                Console.WriteLine(item);
            }
        }

        static int[] TwoSum(int[] nums, int target)
        {
            int[] solution = new int[2]; //To store the indices
            int[] noSolution = { -1 };

            for (int i = 0; i < nums.Length; i++) //To loop through each number in nums
            {
                
                for (int t = 0; t < nums.Length; t++) //To loop through each number in nums
                {
                    if (i == t)
                    {
                        continue; // to ensure we do not add a number to itself
                    }
                    else if ((nums[i] + nums[t]) == target ) //adding the correct sum to the returned array
                    {
                        solution[0] = i;
                        solution[1] = t;
                        return solution;
                    }
                    

                }
            }

            return noSolution; //To show that no two numbers in the array add up to target
        }

    }
}
