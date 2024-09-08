using System.Diagnostics.Metrics;

namespace LeetCodeAlgorithms.Hard
{
    class _0010RegularExpressionMatching
    {

        public bool IsMatch(string s, string p)
        {
            var asteriskSet = new HashSet<char>();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] == '*')
                {
                    asteriskSet.Add(p[i - 1]);
                    if (p[i-1] == '.')
                    {
                        return true;
                    }
                }
            }
            var counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (p[i] == '*')
                {
                    counter++;
                }

                if (asteriskSet.Contains(s[i]))
                {
                    continue;
                }

                if (i > p.Length - 1)
                {
                    return false;
                }

                if (p[i] == '.')
                {
                    continue;
                }


                if (s[i] != p[i+ counter])
                {
                    return false;
                }
            }
            return true;

        }

        [Test]
        public void TestCase()
        {
            var result = IsMatch("aa","a");
            var expectedResult = false;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = IsMatch("aa","a*");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = IsMatch("ab",".*");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = IsMatch("aab", "c*a*b");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase5()
        {
            var result = IsMatch("mississippi", "mis*is*ip*.");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
