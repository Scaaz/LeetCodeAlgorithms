namespace LeetCodeAlgorithms.Easy
{
    internal class _0014LongestCommonPrefix
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1387515344/
        /// Runtime: 71ms
        /// Memory: 42.23MB
        /// </summary>  
        public string LongestCommonPrefix(string[] strs)
        {
            var Longest = "";
            int minLength = strs.Min(y => y.Length);
            for (int i = 0; i < minLength; i++)
            {
                var currentLetter = strs[0][i];
                foreach(var word in strs)
                {
                    if(word[i] != currentLetter)
                    {
                        return Longest;
                    }
                }
                Longest += strs[0][i];
            }       
            return Longest;
        }



        [Test]
        public void TestCase()
        {
            var result = LongestCommonPrefix(["flower", "flow", "flight"]);
            var expectedResult = "fl";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = LongestCommonPrefix(["dog", "racecar", "car"]);
            var expectedResult = "";
            Assert.That(result, Is.EqualTo(expectedResult));
        }


    }
}
