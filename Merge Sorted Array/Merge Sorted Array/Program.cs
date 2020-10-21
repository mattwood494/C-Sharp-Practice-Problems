using System;

namespace Merge_Sorted_Array
{

    //    Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.

    //    Note:

    //    The number of elements initialized in nums1 and nums2 are m and n respectively.
    //    You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
    //    Example:

    //    Input:
    //    nums1 = [1, 2, 3, 0, 0, 0], m = 3
    //    nums2 = [2, 5, 6], n = 3

    //    Output: [1,2,2,3,5,6]


    //    Constraints:

    //    -10^9 <= nums1[i], nums2[i] <= 10^9
    //    nums1.length == m + n
    //    nums2.length == n
    class Program
    {
        static void Main(string[] args)
        {
            
            int filledLength1 = 3; //will use this number to mark where to start for loop
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int[] nums2 = { 2, 5, 6 };
            int index2 = 0; //use this as the index for nums2 in for loop

            
            //add each item from nums2 to nums1 starting with the first empty index in nums1
            for (int i = filledLength1; i < nums1.Length; i++)
            {
                nums1[i] = nums2[index2];
                filledLength1++;
                index2++;
            }

            

            //Sort the array
            Array.Sort(nums1);


            // to confirm that desired result has been obtained
            foreach (var item in nums1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
