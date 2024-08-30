namespace LeetCodeAlgorithms.Easy
{
    internal class _7ReverseInteger
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1373591005/
        /// Runtime: 21ms
        /// Memory: 28.88MB
        /// TODO - do it without abusing try catch
        /// </summary>  
        public int Reverse(int x)
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
    }
}
