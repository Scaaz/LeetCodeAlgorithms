namespace LeetCodeAlgorithms.Easy
{
    internal class _7ReverseInteger
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1373610664/
        /// Runtime: 22ms
        /// Memory: 26.87
        /// </summary> 
        static int Reverse(int x)
        {
            int result = 0;

            var overflow = int.MaxValue / 10;
            var negativeOverflow = int.MinValue / 10;
            while (x != 0)
            {
                int lastDigit = x % 10;
                if (result > overflow || result < negativeOverflow)
                {
                    return 0;
                }
                result = result * 10 + lastDigit;
                x /= 10;
            }
            return result;
        }

        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1373591005/
        /// Runtime: 21ms
        /// Memory: 28.88MB
        /// OLD "illegal" try catch version
        /// </summary>  
        public int ReverseOLD(int x)
        {
            bool isNegative = false;
            if(x<0)
            {
                isNegative = true;
                x *= -1;
            }
            var s = x.ToString();
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            int result = 0;
            try
            {
                result = Int32.Parse(charArray);

            }
            catch
            {
                return result;
            }         

            if(isNegative)
            {
                result *= -1;
            }
            return result;
        }

        [Test]
        public void TestCase()
        {
            var result = Reverse(123);
            var expectedResult = 321;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = Reverse(-123);
            var expectedResult = -321;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = Reverse(120);
            var expectedResult = 21;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = Reverse(1534236469);
            var expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        [Test]
        public void TestCase5()
        {
            var result = Reverse(-2147483412);
            var expectedResult = -2143847412;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
