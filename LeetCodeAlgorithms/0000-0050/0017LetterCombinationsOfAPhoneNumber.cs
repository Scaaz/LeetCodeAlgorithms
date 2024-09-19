namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0017LetterCombinationsOfAPhoneNumber
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1395531596/
        /// Runtime: 111ms
        /// Memory: 47.30MB
        /// </summary> 
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>
            {
                {2, ["a","b","c"]},
                {3, ["d","e","f"]},
                {4, ["g","h","i"]},
                {5, ["j","k","l"]},
                {6, ["m","n","o"]},
                {7, ["p","q","r","s"]},
                {8, ["t","u","v"]},
                {9, ["w","x","y","z"]}
            };

            if (digits.Length == 0)
            {
                return result;
            }
            result = dictionary[int.Parse(digits[0].ToString())];

            for (int i = 1; i < digits.Length; i++)
            {
                result = Combine(result, dictionary[int.Parse(digits[i].ToString())]);
            }

            return result;
        }

        private List<string> Combine(List<string> first, List<string> second)
        {
            var result = new List<string>();
            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    result.Add(first[i]);
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                result[i] += second[i % second.Count];
            }

            return result;
        }

        [Test]
        public void TestCase()
        {
            var result = LetterCombinations("23");
            IList<string> expectedResult = [ "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" ];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase2()
        {
            var result = LetterCombinations("");
            IList<string> expectedResult = [];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase3()
        {
            var result = LetterCombinations("2");
            IList<string> expectedResult = ["a", "b", "c"];
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void TestCase4()
        {
            var result = LetterCombinations("234");
            IList<string> expectedResult = ["adg", "adh", "adi", "aeg", "aeh", "aei", "afg", "afh", "afi", "bdg", "bdh", "bdi", "beg", "beh", "bei", "bfg", "bfh", "bfi", "cdg", "cdh", "cdi", "ceg", "ceh", "cei", "cfg", "cfh", "cfi"];
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
