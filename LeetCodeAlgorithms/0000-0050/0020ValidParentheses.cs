namespace LeetCodeAlgorithms._0000_0050
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1407355411/
    /// Runtime: 64ms
    /// Memory: 39.35MB
    /// </summary> 
    internal class _0020ValidParentheses
    {
        public bool IsValid(string s)
        {
            var result = ' ';
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(s[i]);
                        break;

                    case '[':
                        stack.Push(s[i]);
                        break;

                    case '{':
                        stack.Push(s[i]);
                        break;

                    case ')':
                        stack.TryPop(out result);
                        if (result != '(')
                        {                            
                            return false;
                        }
                        break;

                    case ']':
                        stack.TryPop(out result);
                        if (result != '[')
                        {
                            return false;
                        }
                        break;

                    case '}':
                        stack.TryPop(out result);
                        if (result != '{')
                        {
                            return false;
                        }
                        break;
                }
            }
            if(stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        [Test]
        public void TestCase()
        {
            var result = IsValid("()");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = IsValid("()[]{}");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = IsValid("(]");
            var expectedResult = false;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = IsValid("([])");
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
