namespace LeetCodeAlgorithms.Medium
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1371413661/
    /// Runtime: 64ms
    /// Memory: 42.67MB
    /// </summary>  
    internal class _0003LongestSubstring
    {   
        private int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int CurrentStreak = 0;
            int record = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.TryAdd(s[i], i))
                {
                    CurrentStreak = 0;
                    i = dict[s[i]];
                    dict.Clear();
                }
                else
                {
                    CurrentStreak++;
                    if (CurrentStreak > record)
                    {
                        record = CurrentStreak;
                    }
                }
            }
            return record;
        }

        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("dvdf", 3)]
        public void TestCase(string Input, int expectedResult)
        {
            var result = LengthOfLongestSubstring(Input);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
