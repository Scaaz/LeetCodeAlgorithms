namespace LeetCodeAlgorithms._0000_0050
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1396470252/
    /// Runtime: 115ms
    /// Memory: 47.62MB
    /// </summary> 
    internal class _00184Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var quadruplets = new List<IList<int>>();

            // If the array has less than 4 elements, return an empty list
            if (nums.Length < 4) return quadruplets;

            // Sort the array to make it easier to skip duplicates and use the two-pointer technique
            Array.Sort(nums);

            // First loop for the first element of the quadruplet
            for (int i = 0; i < nums.Length - 3; i++)
            {
                // Skip duplicates for the first element
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                // Second loop for the second element of the quadruplet
                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    // Skip duplicates for the second element
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    // Two-pointer approach for the remaining two elements
                    int left = j + 1;
                    int right = nums.Length - 1;

                    while (left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];

                        if (sum == target)
                        {
                            // Add the quadruplet
                            quadruplets.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                            // Move left and right pointers while skipping duplicates
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;

                            // Move pointers inward
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            // If sum is too small, move the left pointer to the right
                            left++;
                        }
                        else
                        {
                            // If sum is too large, move the right pointer to the left
                            right--;
                        }
                    }
                }
            }

            return quadruplets;
        }



        [Test]
        public void TestCase()
        {
            var result = FourSum([1, 0, -1, 0, -2, 2], 0);
            List<IList<int>> expectedResult = [[-1, -1, 2], [-1, 0, 1]];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = FourSum([2, 2, 2, 2, 2], 8);
            List<IList<int>> expectedResult = [[2, 2, 2, 2]];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = FourSum([1000000000, 1000000000, 1000000000, 1000000000], -294967296);
            List<IList<int>> expectedResult = [];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = FourSum([1, -2, -5, -4, -3, 3, 3, 5], -11);
            List<IList<int>> expectedResult = [[-5, -4, -3, 1]];
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
