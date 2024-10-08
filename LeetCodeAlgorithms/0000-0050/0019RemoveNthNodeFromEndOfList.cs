﻿using LeetCodeAlgorithms.Common;
using LeetCodeAlgorithms.CommonFiles;

namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0019RemoveNthNodeFromEndOfList
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1400025085/
        /// Runtime: 64ms
        /// Memory: 41.18MB
        /// </summary> 
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            int size = 0;
            ListNode temp = head;
            ListNode? beforeRemovedOne = null;

            while (temp != null)
            {
                temp = temp.next;
                size++;
            }
            if (size == 1) return null;  //avoid runtime error single element
            else if (size == n) return head.next; //handle first case elimination, so head not become null
            temp = head;
            while (size != n) // assign temp to remove node 
            {
                beforeRemovedOne = temp;
                temp = temp.next;
                size--;
            }
            //link before node to next node of removed one
            beforeRemovedOne.next = temp.next;
            return head;
        }

        [Test]
        public void TestCase()
        {
            var result = RemoveNthFromEnd( ListNode.GenerateList([1, 2, 3, 4, 5]), 2);
            int[] expectedResult = [1, 2, 3, 5];
            AssertHelper.AssertLinkList(ListNode.GenerateList([1, 2, 3, 5 ]), result);
        }

        [Test]
        public void TestCase2()
        {
            var result = RemoveNthFromEnd(ListNode.GenerateList([1]), 1);
            Assert.IsNull(result);
        }

        [Test]
        public void TestCase3()
        {
            var result = RemoveNthFromEnd(ListNode.GenerateList([1, 2]), 1);
            var expectedResult = ListNode.GenerateList([1]);
            AssertHelper.AssertLinkList(expectedResult, result);
        }
    }
}
