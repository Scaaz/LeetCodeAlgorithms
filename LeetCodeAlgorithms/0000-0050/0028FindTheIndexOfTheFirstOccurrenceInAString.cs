namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0028FindTheIndexOfTheFirstOccurrenceInAString
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1417444499/
        /// Runtime: 40ms
        /// Memory: 39.75MB
        /// </summary> 
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }


        [Test]
        public void TestCase()
        {
            var result = StrStr("sadbutsad", "sad");
            var expectedResult = 0;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = StrStr("leetcode", "leeto");
            var expectedResult = -1;
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
