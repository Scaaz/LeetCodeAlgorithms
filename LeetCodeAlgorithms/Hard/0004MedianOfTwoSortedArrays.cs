namespace LeetCodeAlgorithms.Hard
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1371511037/
    /// Runtime: 95ms
    /// Memory: 54.72MB
    /// </summary>  
    internal class _0004MedianOfTwoSortedArrays
    {
        private double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var len1 = nums1.Length;
            var len2 = nums2.Length;
            var totallen = len1 + len2;
            int[] concat = [.. nums1, .. nums2];
            Array.Sort(concat);
            double median = 0.0;
            if(totallen%2 == 0)
            {
                var center = (int)totallen / 2;
                return (concat[center] + concat[center-1]) /2.0;
            }
            median = concat[(int)(totallen/2)];
            return median;
        }

        [Test]
        public void TestCase()
        {
            int[] nums1 =  [ 1, 3 ];
            int[] nums2 =  [ 2 ];

            var result = FindMedianSortedArrays(nums1, nums2);
            var expectedResult = 2;

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2() {
            int[] nums1 = [1, 2];
            int[] nums2 = [3, 4];

            var result = FindMedianSortedArrays(nums1, nums2);
            var expectedResult = 2.5;

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
