namespace LeetCodeAlgorithms.Easy
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1370527752/
    /// Runtime: 105ms
    /// Memory: 49.03MB
    /// </summary>  
    internal class _0001TwoSum
    {

        private int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            Dictionary<int,int> dict = new ();

            for (int i = 0; i < nums.Length; i++)
            {
                dict[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++)
            {      
               int missingValue = target - nums[i];
                if(dict.ContainsKey(missingValue) && dict[missingValue] != i)
                {
                    return [i, dict[missingValue]];
                }
            }
            return result;
        }
        [Test]
        public void TestCase()
        {

            var nums = new int[] { 2,7,11,15 };
            var target = 9;
            var result = TwoSum(nums, target);
            var expectedResult = new int[] {0,1};
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var nums = new int[] { 3,2,4 };
            var target = 6;
            var result = TwoSum(nums, target);
            var expectedResult = new int[] { 1, 2};
            Assert.That(result, Is.EquivalentTo(expectedResult));
        }
    }
}
