using System.Text;

namespace LeetCodeAlgorithms.Medium
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1378128172/
    /// Runtime: 63ms
    /// Memory: 52.29MB
    /// </summary>
    internal class _6ZigzagConversion
    {
        private string Convert(string s, int numRows)
        {
            if(numRows == 1)
            {
                return s;
            }

            StringBuilder[] result = new StringBuilder[numRows];
            var direction = 1;
            var i = 0;
            for (int j = 0; j < numRows; j++)
            {
                result[j] = new StringBuilder();
            }

            foreach (char c in s)
            {
                result[i].Append(c);
                i += direction;
                if (i == numRows - 1 || i == 0)
                {
                    direction *= -1;
                }
            }
            return string.Concat(result.Select(sb => sb.ToString()));
        }

        [Test]
        public void TestCase()
        {
            var result = Convert("PAYPALISHIRING",3 );
            var expectedResult = "PAHNAPLSIIGYIR";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = Convert("PAYPALISHIRING", 4);
            var expectedResult = "PINALSIGYAHRPI";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = Convert("A", 1);
            var expectedResult = "A";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
