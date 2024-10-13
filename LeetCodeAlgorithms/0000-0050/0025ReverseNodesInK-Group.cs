using LeetCodeAlgorithms.Common;
using LeetCodeAlgorithms.CommonFiles;

namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0025ReverseNodesInK_Group
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1421107794/
        /// Runtime: 76ms
        /// Memory: 44.95MB
        /// </summary>
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k == 1)
            {
                return head;
            }
            int count = 0;
            ListNode current = head;
            while (current != null && count < k)
            {
                current = current.next;
                count++;
            }

            if (count < k)
            {
                return head; 
            }

            ListNode prev = null;
            ListNode next = null;
            current = head;
            for (int i = 0; i < k; i++)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head.next = ReverseKGroup(current, k);
            return prev;
        }

        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode prev = dummy;
            ListNode curr = head;

            while (curr != null && curr.next != null)
            {
                var first = curr;
                var second = curr.next;

                first.next = second.next;
                second.next = first;
                prev.next = second;

                prev = first;
                curr = prev.next;
            }
            return dummy.next;
        }

        [Test]
        public void TestCase()
        {
            var result = ReverseKGroup(ListNode.GenerateList([1, 2, 3, 4, 5]), 2);
            var expectedResult = ListNode.GenerateList([2, 1, 4, 3, 5]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }

        [Test]
        public void TestCase2()
        {
            var result = ReverseKGroup(ListNode.GenerateList([1, 2, 3, 4, 5]), 3);
            var expectedResult = ListNode.GenerateList([3, 2, 1, 4, 5]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }
    }
}
