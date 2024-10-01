using LeetCodeAlgorithms.Common;
using Newtonsoft.Json.Linq;

namespace LeetCodeAlgorithms._0000_0050
{
    /// <summary>
    /// Submission: https://leetcode.com/submissions/detail/1408547129/
    /// Runtime: 59ms
    /// Memory: 42.70MB
    /// </summary> 
    internal class _0021MergeTwoSortedLists
    {
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
            var result = MergeTwoLists(new ListNode([1, 2, 4]), new ListNode([1, 3, 4]));
            var expectedResult = new ListNode([1, 1, 2, 3, 4, 4]);
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase2()
        {
            var result = MergeTwoLists(new ListNode([]), new ListNode([]));
            var expectedResult = new ListNode([]);
            Assert.That(result, Is.EqualTo(expectedResult));
        }        
        
        [Test]
        public void TestCase3()
        {
            var result = MergeTwoLists(new ListNode([]), new ListNode([0]));
            var expectedResult = new ListNode([0]);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
