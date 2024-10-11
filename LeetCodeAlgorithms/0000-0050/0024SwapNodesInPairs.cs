using LeetCodeAlgorithms.Common;
using LeetCodeAlgorithms.CommonFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0024SwapNodesInPairs
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1419255627/
        /// Runtime: 57ms
        /// Memory: 39.79MB
        /// </summary>
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
            var result = SwapPairs(ListNode.GenerateList([]));
            Assert.IsNull(result);
        }

        [Test]
        public void TestCase2()
        {
            var result = SwapPairs(ListNode.GenerateList([1]));
            var expectedResult = ListNode.GenerateList([1]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }

        [Test]
        public void TestCase3()
        {
            var result = SwapPairs(ListNode.GenerateList([1,2,3]));
            var expectedResult = ListNode.GenerateList([2,1,3]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }

        [Test]
        public void TestCase4()
        {
            var result = SwapPairs(ListNode.GenerateList([1,2,3,4]));
            var expectedResult = ListNode.GenerateList([2,1,4,3]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }
    }
}
