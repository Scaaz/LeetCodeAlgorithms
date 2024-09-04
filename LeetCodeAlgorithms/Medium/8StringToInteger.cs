namespace LeetCodeAlgorithms.Medium
{
    internal class _8StringToInteger
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1378990174/
        /// Runtime: 47ms
        /// Memory: 40.68MB
        /// </summary>
        public int MyAtoi(string s)
        {
            int result = 0;
            bool? isNegative = null;
            var resultString = "";
            bool firstSymbolUsed = false;
            foreach (char c in s)
            {
                
                if (resultString.Length == 0 && isNegative == null && c == '-')
                {
                    if (firstSymbolUsed)
                    {
                        return 0;
                    }
                firstSymbolUsed = true;
                isNegative = true;
                    continue;
                }
                else if (resultString.Length == 0 && isNegative == null && c == '+')
                {
                    if (firstSymbolUsed)
                    {
                        return 0;
                    }
                firstSymbolUsed = true;
                isNegative = false;
                    continue;
                }
                else if (resultString.Length == 0 && c == ' ')
                {
                    if (firstSymbolUsed)
                    {
                        return 0;
                    }
                    continue;
                }
                else if (resultString.Length == 0 && c == '0')
                {
                    firstSymbolUsed = true;
                    continue;
                }


                if (c < 48 || c > 57)
                {
                    //not integer
                    break;
                }
                else
                {                  
                  resultString += c;          
                }   
            }
            if (resultString.Length == 0)
            {
                return result;
            }
            else
            {
                if(resultString.Length > 10)
                {
                    if (isNegative == true)
                    {
                        return int.MinValue;
                    }
                    else 
                    {
                        return int.MaxValue;
                    }
                }
                if (long.TryParse(resultString, out long longResult))
                {
                    if (isNegative == true)
                    {
                        longResult *= -1;
                    }

                    if (longResult > int.MaxValue)
                    {
                        result = int.MaxValue;
                    }
                    else if (longResult < int.MinValue)
                    {
                        result = int.MinValue;
                    }
                    else
                    {
                        result = (int)longResult;
                    }
                }
            } 
            return result;
        }


        [Test]
        public void TestCase()
        {
            var result = MyAtoi("42");
            var expectedResult = 42;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = MyAtoi("1337d95");
            var expectedResult = 1337;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        [Test]
        public void TestCase3()
        {
            var result = MyAtoi("   -042");
            var expectedResult = -42;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase4()
        {
            var result = MyAtoi("-91283472332");
            var expectedResult =-2147483648;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase5()
        {
            var result = MyAtoi("21474836460");
            var expectedResult =2147483647;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase6()
        {
            var result = MyAtoi("-91283472332");
            var expectedResult = -2147483648;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase7()
        {
            var result = MyAtoi("   +0 123");
            var expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void TestCase8()
        {
            var result = MyAtoi("+-12");
            var expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
        
        [Test]
        public void TestCase9()
        {
            var result = MyAtoi("20000000000000000000");
            var expectedResult = 2147483647;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        [Test]
        public void TestCase10()
        {
            var result = MyAtoi("0-1");
            var expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase11()
        {
            var result = MyAtoi("  0000000000012345678");
            var expectedResult = 12345678;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
