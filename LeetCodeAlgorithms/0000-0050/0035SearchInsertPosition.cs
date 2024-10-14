﻿namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0035SearchInsertPosition
    {
        //better code, somehow same runtime????????
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1422486868/
        /// Runtime: 75ms
        /// Memory: 41.87MB
        /// </summary> 
        public int SearchInsert(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }

        //simpliest, first try
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1422464682/
        /// Runtime: 75ms
        /// Memory: 41.88MB
        /// </summary> 
        public int SearchInsertSimple(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}

