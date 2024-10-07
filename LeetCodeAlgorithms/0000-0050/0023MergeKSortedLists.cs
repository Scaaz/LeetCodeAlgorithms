using LeetCodeAlgorithms.Common;
using LeetCodeAlgorithms.CommonFiles;

namespace LeetCodeAlgorithms._0000_0050
{
    internal class _0023MergeKSortedLists
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1415137675/
        /// Runtime: 97ms
        /// Memory: 52.36MB
        /// </summary> 
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
            return null;

            int last = lists.Length - 1;
            while (last != 0)
            {
                int i = 0;
                int j = last;
                while (i < j)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[j]);
                    i++;
                    j--;
                }
                if (i >= j)
                    last = j;
            }
            return lists[0];
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            var head = new ListNode();
            var currentNode = head;
            while (list1 != null && list2 != null)
            {
                int valToAdd = 0;

                if (list1.val <= list2.val)
                {
                    valToAdd = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    valToAdd = list2.val;
                    list2 = list2.next;
                }

                ListNode tmp = new ListNode(valToAdd);
                currentNode.next = tmp;
                currentNode = currentNode.next;
            }
            if (list1 == null) currentNode.next = list2;
            else if (list2 == null) currentNode.next = list1;

            return head.next;
        }

        [Test]
        public void TestCase()
        {
            var result = MergeKLists(new ListNode[] { ListNode.GenerateList([1, 4, 5]), ListNode.GenerateList([1, 3, 4]), ListNode.GenerateList([2, 6])});
            var expectedResult = ListNode.GenerateList([1, 1, 2, 3, 4, 4, 5, 6]);
            AssertHelper.AssertLinkList(result, expectedResult);
        }
    }
}
