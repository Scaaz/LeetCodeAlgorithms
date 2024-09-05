namespace LeetCodeAlgorithms.Easy
{
    internal class _0013RomanToInteger
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1379996167/
        /// Runtime: 44ms
        /// Memory: 47.62MB
        /// </summary> 
        private int RomanToInt(string s)
        {
            int result = 0;
            int currentNumber = 0;
            int nextNumber = 0;
            bool nextReuesd = false;
            for(int i=0; i<s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    switch (s[i+1])
                    {
                        case 'I':
                            nextNumber = 1;
                            break;
                        case 'V':
                            nextNumber = 5;
                            break;
                        case 'X':
                            nextNumber = 10;
                            break;
                        case 'L':
                            nextNumber = 50;
                            break;
                        case 'C':
                            nextNumber = 100;
                            break;
                        case 'D':
                            nextNumber = 500;
                            break;
                        case 'M':
                            nextNumber = 1000;
                            break;
                    }
                }

                if(!nextReuesd)
                {
                    switch (s[i])
                    {
                        case 'I':
                            currentNumber = 1;
                            break;
                        case 'V':
                            currentNumber = 5;
                            break;
                        case 'X':
                            currentNumber = 10;
                            break;
                        case 'L':
                            currentNumber = 50;
                            break;
                        case 'C':
                            currentNumber = 100;
                            break;
                        case 'D':
                            currentNumber = 500;
                            break;
                        case 'M':
                            currentNumber = 1000;
                            break;
                    }
                }

                if(nextNumber > currentNumber)
                {
                    currentNumber *= -1;
                }
                result += currentNumber;
                currentNumber = nextNumber;
                nextReuesd = true;
            }
            return result;
        }

        [Test]
        public void TestCase()
        {
            var result = RomanToInt("III");
            var expectedResult = 3;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = RomanToInt("LVIII");
            var expectedResult = 58;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = RomanToInt("MCMXCIV");
            var expectedResult = 1994;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
