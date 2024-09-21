using NUnit.Framework.Internal;
using System.Text;

namespace LeetCodeAlgorithms._0200_0250
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1397405988/
    /// Runtime: 190ms
    /// Memory: 41.71MB
    /// </summary>  
    internal class _0214ShortestPalindrome
    {
        public string ShortestPalindrome(string s)
        {
            int len = 0;
            for (int i = s.Length / 2; i >= 0; i--)
            {
                if ((len = IsPalindome(i, s)) > 0) break;
            }

            var result = new StringBuilder();
            for (int i = s.Length - 1; i >= len; i--)
            {
                result.Append(s[i]);
            }

            result.Append(s);
            return result.ToString();
        }

        private int IsPalindome(int middle, string s)
        {
            // Case with odd length palindome
            int l = middle - 1;
            int r = middle + 1;
            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r]) break;
                l--;
                r++;
            }

            if (l < 0) return middle * 2 + 1;

            // Case with even length palindome
            l = middle - 1;
            r = middle;
            while (l >= 0 && r < s.Length)
            {
                if (s[l] != s[r]) break;
                l--;
                r++;
            }

            if (l < 0) return middle * 2;

            return 0;
        }

        [Test]
        public void TestCase()
        {
            var result = ShortestPalindrome("aacecaaa");
            var expectedResult = "aaacecaaa";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = ShortestPalindrome("abcd");
            var expectedResult = "dcbabcd";
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
