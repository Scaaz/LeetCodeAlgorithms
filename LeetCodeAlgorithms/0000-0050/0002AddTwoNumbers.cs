using LeetCodeAlgorithms.Common;

namespace LeetCodeAlgorithms.Medium
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1366819141/
    /// Runtime: 72ms
    /// Memory: 51.41MB
    /// </summary>  
    public class _0002AddTwoNumbers
    {
        private ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool extraOne = false)
        {
            var finalListNode = new ListNode();
            finalListNode.val = l1.val + l2.val;

            if (extraOne)
            {
                finalListNode.val++;
                extraOne = false;
            }

            if (finalListNode.val >= 10)
            {
                finalListNode.val -= 10;
                extraOne = true;
            }

            if (l1.next != null || l2.next != null)
            {
                finalListNode.next = AddTwoNumbers(l1?.next ?? new ListNode(), l2?.next ?? new ListNode(), extraOne);
            }
            else if (extraOne)
            {
                finalListNode.next = new ListNode();
                finalListNode.next.val = 1;
            }

            return finalListNode;
        }

        private static bool RecursiveCheck(ListNode result, ListNode expectedResult)
        {
            if (result.val != expectedResult.val)
            {
                return false;
            }

            if (result.next != null && expectedResult == null || result.next == null && expectedResult != null)
            {
                return false;
            }

            if (result.next != null && expectedResult != null)
            {
                RecursiveCheck(result.next, expectedResult.next);
            }
            return true;
        }

        [Test]
        public void TestCase()
        {
            ListNode l1 = new ListNode();
            l1.val = 2;
            l1.next = new ListNode() { val = 4, };
            l1.next.next = new ListNode() { val = 3 };

            ListNode l2 = new ListNode();
            l2.val = 5;
            l2.next = new ListNode() { val = 6, };
            l2.next.next = new ListNode() { val = 4 };

            var result = AddTwoNumbers(l1, l2);

            ListNode expectedResult = new ListNode();
            expectedResult.val = 7;
            expectedResult.next = new ListNode() { val = 0, };
            expectedResult.next.next = new ListNode() { val = 8 };

            Assert.That(RecursiveCheck(result, expectedResult), Is.True);
        }
    }
}
