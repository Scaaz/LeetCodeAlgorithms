using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Medium
{
    internal class _00163SumClosest
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1394852886/
        /// Runtime: 75ms
        /// Memory: 42.10MB
        /// </summary>
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = nums[0] + nums[1] + nums[2];

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (Math.Abs(sum - target) < Math.Abs(result - target))
                    {
                        result = sum;
                    }

                    if (sum < target)
                        left++;
                    else if (sum > target)
                        right--;
                    else
                        return sum;
                }
            }
            return result;
        }

        [Test]
        public void TestCase()
        {
            var result = ThreeSumClosest([-1, 2, 1, -4], 1);
            int expectedResult = 2;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = ThreeSumClosest([0,0,0], 1);
            int expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = ThreeSumClosest([0, 1, 2], 0);
            int expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = ThreeSumClosest([1, 1, 1, 0], 100);
            int expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
