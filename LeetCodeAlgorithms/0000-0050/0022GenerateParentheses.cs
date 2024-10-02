using System.Text;

namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0022GenerateParentheses
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1409478920/
        /// Runtime: 90ms
        /// Memory: 49.07MB
        /// </summary> 
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            int openPara = n - 1;
            int closePara = n;
            StringBuilder str = new StringBuilder("(");
            void BackTrack(StringBuilder sb, int open, int close)
            {
                if (open == 0 && close == 0)
                {
                    result.Add(sb.ToString());
                    return;
                }
                if (open > 0)
                {
                    sb.Append('(');
                    BackTrack(sb, open-1, close);
                    sb.Length--;
                }
                if (close > open)
                {
                    sb.Append(')');
                    BackTrack(sb, open, close-1);
                    sb.Length--;
                }
            }
            BackTrack(str, openPara, closePara);

            return result;
        }

        [Test]
        public void TestCase()
        {
            var result = GenerateParenthesis(3);
            var expectedResult = new List<string>() { "((()))", "(()())", "(())()", "()(())", "()()()" };
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = GenerateParenthesis(1);
            var expectedResult = new List<string>() { "()" };
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
