namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0029DivideTwoIntegers
    {
        // divide two integers without using multiplication, division, and mod operator.
        // casual adding was "too slow"
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1424141171/
        /// Runtime: 26ms
        /// Memory: 26.74MB
        /// </summary>  
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            bool sign = (dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0);

            dividend = dividend > 0 ? -dividend : dividend;
            divisor = divisor > 0 ? -divisor : divisor;

            int result = 0;
            while (dividend <= divisor)
            {
                int temp = divisor, count = 1;
                while (temp >= (int.MinValue >> 1) && dividend <= (temp << 1))
                {
                    temp <<= 1;
                    count <<= 1;
                }
                dividend -= temp;
                result += count;
            }
            return sign ? result : -result;
        }


        [TestCase(10, 3, 3)]
        [TestCase(7, -3, -2)]
        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, -1)]
        public void TestCase(int divident, int divisor, int expectedResult)
        {
            var result = Divide(divident, divisor);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
