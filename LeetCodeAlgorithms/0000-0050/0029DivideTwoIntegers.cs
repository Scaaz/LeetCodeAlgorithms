namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0029DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (dividend == int.MaxValue && divisor == 1)
                return int.MaxValue;
            else if (dividend == int.MaxValue && divisor == -1)
                return int.MinValue + 1;
            else if ((dividend == int.MinValue && divisor == -1))
                return int.MaxValue;
            else if (((dividend == int.MinValue && divisor == 1)))
                return int.MinValue;

            int current = 0;
            int sum = 0;
            int sign = 1;

            if(dividend > 0 && divisor <0 || dividend < 0 && divisor > 0)
            {
                sign = -1;
            }
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);
          
            while (true)
            {
                sum += divisor;
                if (sum > dividend)
                {
                    return sign*current;
                }
                current++;
            }
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
