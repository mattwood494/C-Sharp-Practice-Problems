using System;

namespace Sort_An_Array
{
    // Given an array of integers nums, sort the array in ascending order.



    // Example 1:

    // Input: nums = [5, 2, 3, 1]
    // Output: [1,2,3,5]
    // Example 2:

    // Input: nums = [5, 1, 1, 2, 0, 0]
    // Output: [0,0,1,1,2,5]



    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 3, 1 };
            int arrayLength = nums.Length;
            int tmp = 0;
            
            for (int i = 0; i < arrayLength - 1; i++)
            {
                int min_index = i;
                int j = i + 1;

                while (j < arrayLength)
                {
                    if (nums[j] < nums[min_index]) 
                    {
                        tmp = nums[min_index];
                        nums[min_index] = nums[j];
                        nums[j] = tmp;
                    }
                    min_index = j;
                    j++;
                }

                
                
            }
        }
    }
}
