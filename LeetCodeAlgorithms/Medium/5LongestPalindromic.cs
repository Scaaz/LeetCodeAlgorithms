namespace LeetCodeAlgorithms.Medium
{
    internal class _5LongestPalindromic
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1374656682/
        /// Runtime: 66ms
        /// Memory: 57.66MB
        /// </summary>  
        private string LongestPalindrome(string s)
        {
            var result = "";
            var resLen = 0;
            if(s == null || s == string.Empty)
            {
                return result;
            }
            for (int i = 0; i < s.Length; i++)
            {
                var l = i;
                var r = i;               

                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > resLen)
                    {
                        result = s.Substring(l, r - l+1);
                        resLen = r - l + 1;
                    }
                    l -= 1;
                    r += 1;

                }
               
                    l = i;
                    r = i+1;

                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > resLen)
                    {
                        result = s.Substring(l, r - l+1);
                        resLen = r - l + 1;
                    }
                    l -= 1;
                    r += 1;
                }
            }
                return result;
        }

        [Test]
        public void TestCase()
        {
            var result = LongestPalindrome("ac");
            var expectedResult = "a";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = LongestPalindrome("cbbd");
            var expectedResult = "bb";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = LongestPalindrome("abb");
            var expectedResult = "bb";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = LongestPalindrome("ccd");
            var expectedResult = "cc";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase5()
        {
            var result = LongestPalindrome("aaabbbb");
            var expectedResult = "bbbb";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase6()
        {
            var result = LongestPalindrome("adam");
            var expectedResult = "ada";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
