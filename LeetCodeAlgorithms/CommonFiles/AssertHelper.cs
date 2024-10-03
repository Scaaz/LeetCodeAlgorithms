using LeetCodeAlgorithms.Common;

namespace LeetCodeAlgorithms.CommonFiles
{
    public static class AssertHelper
    {
        public static void AssertLinkList( ListNode actual,int[] expected)
        {
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected.Length > 0);

            var current = actual;
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.IsNotNull(current);
                Assert.AreEqual(expected[i], current.val);
                current = current.next;
            }

            Assert.IsNull(current);
        }

        public static void AssertLinkList( ListNode actual, ListNode expected)
        {;
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            Assert.IsTrue(expected!=null);

            var current = actual;
            while(expected != null)
            { 
                Assert.IsNotNull(current);
                Assert.AreEqual(expected.val, current.val);
                current = current.next;
                expected = expected.next;
            }

            Assert.IsNull(current);
        }
    }
}
