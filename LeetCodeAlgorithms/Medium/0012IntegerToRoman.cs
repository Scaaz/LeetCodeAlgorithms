using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms.Medium
{
    class _0012IntegerToRoman
    {

        public string IntToRoman(int num)
        {
            var roman = "";
            var m = (int)(num / 1000);
            num = num % 1000;
            var d = (int)(num / 500);
            num = num % 500;
            var c = (int)(num / 100);
            num = num % 100;
            var l = (int)(num / 50);
            num = num % 50;
            var x = (int)(num / 10);
            num = num % 10;
            var v = (int)(num / 5);
            num = num % 5;
            var i = (int)(num);


            while(m>0)
            {
                roman += "M";
                m--;
            }
            while (d > 0)
            {
                if (c > 3)
                {
                    roman += "CM";
                    c = c - 4;
                }
                else
                {
                    roman += "D";
                }
                d--;
            }
            while (c > 0)
            {
                if (c > 3)
                {
                    roman += "CD";
                    c = c - 4;
                }
                else
                {
                    roman += "C";
                }
                            
                c--;
            }
            while (l > 0)
            {
                if ( x > 3)
                {
                    roman += "XC";
                    x = x - 4;
                }
                else
                {
                    roman += "L";
                }
                l--;
            }
            while (x > 0)
            {
                if (x > 3)
                {
                    roman += "XL";
                    x = x - 4;
                }
                else
                {
                    roman += "X";
                }
                x--;
            }
            while (v > 0)
            {
                if (i > 3)
                {
                    roman += "IX";
                    i = i - 4;
                }
                else
                {
                    roman += "V";
                }
                v--;
            }
            while (i > 0)
            {
                if(i>3)
                {
                    roman += "IV";
                    i = i - 4;
                }
                else
                {
                    roman += "I";
                }
                i--;
            }
            return roman;
        }


        [Test]
        public void TestCase()
        {
            var result = IntToRoman(58);
            var expectedResult = "LVIII";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = IntToRoman(3749);
            var expectedResult = "MMMDCCXLIX";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = IntToRoman(1994);
            var expectedResult = "MCMXCIV";
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}
