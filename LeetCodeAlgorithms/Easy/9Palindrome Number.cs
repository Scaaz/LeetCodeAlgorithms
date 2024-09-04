namespace LeetCodeAlgorithms.Easy
{
    internal class _9Palindrome_Number
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1379040406/
        /// Runtime: 50ms
        /// Memory: 32.79MB
        /// </summary> 
        private bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            else
            {
                string StringInt = x.ToString();
                for (int i = 0; i < StringInt.Length / 2; i++)
                {
                    if (StringInt[StringInt.Length - 1 - i] != StringInt[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        //Shortest version, but slower
        private bool ShortestPossible(int x)
        {
            if (x < 0)
                return false;

            return string.Concat(x.ToString().Reverse()) == x.ToString();
        }


        [Test]
        public void TestCase1()
        {
            var result = IsPalindrome(121);
            var expectedResult = true;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = IsPalindrome(-121);
            var expectedResult = false;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = IsPalindrome(10);
            var expectedResult = false;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
