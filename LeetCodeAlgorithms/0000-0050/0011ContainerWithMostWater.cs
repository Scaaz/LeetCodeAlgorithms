namespace LeetCodeAlgorithms.Medium
{
    internal class _0011ContainerWithMostWater
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1387558196/
        /// Runtime: 236ms
        /// Memory: 62.31MB
        /// </summary>
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            var left = 0;
            var right = height.Length - 1;

            while (left < right)
            {
                var area = 0;
                if (height[left] > height[right])
                {
                    area = height[right] * (right-left);
                    right--;
                }
                else
                {
                    area = height[left] * (right-left);
                    left++;
                }           

                if(area > maxArea)
                {
                    maxArea = area;
                }      
            }
            return maxArea;
        }

        [Test]
        public void TestCase()
        {
            var result = MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);
            var expectedResult = 49;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = MaxArea([1, 1]);
            var expectedResult = 1;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
