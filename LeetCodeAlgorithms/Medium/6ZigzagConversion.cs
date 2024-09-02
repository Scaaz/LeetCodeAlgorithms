using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Medium
{
    internal class _6ZigzagConversion
    {
        private string Convert(string s, int numRows)
        {
            if(numRows == 1)
            {
                return s;
            }

            var finalString = "";
            var gap = 2*numRows-2;
            for (int row =0; row < numRows ;row++)
            {
               
                if(row !=0 && row <= numRows/2)
                {
                    gap--;
                    gap--;
                }
                else if (row != 0 && row > numRows / 2)
                {
                    gap++;
                    gap++;
                }

                for (int i = row; i < s.Length; i += gap)
                {
                        finalString += s[i];
                }



                //    for (int i = 0; (2 * numRows - 2 * i + row) < s.Length; i++)
                //{
                //   finalString[i] += s[2 * numRows - 2 * i + row];                        
                //}
            }
            return new string(finalString);
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
