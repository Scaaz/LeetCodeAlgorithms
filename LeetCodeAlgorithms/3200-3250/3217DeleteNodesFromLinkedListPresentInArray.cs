using LeetCodeAlgorithms.Common;

namespace LeetCodeAlgorithms.Medium
{
    internal class _3217DeleteNodesFromLinkedListPresentInArray
    {
        /// <summary>
        /// Submission: https://leetcode.com/submissions/detail/1381441411/
        /// Runtime: 647ms
        /// Memory: 112.27MB
        /// </summary>  
        public ListNode ModifiedList(int[] nums, ListNode? head)
        {
            var numsSet = new HashSet<int>(nums);
            var first = head;
            while(first != null && numsSet.Contains(first.val))
            {
                first = first.next;
            }

            var curr = first;

            while (curr != null && curr.next != null)
            {
                if (numsSet.Contains(curr.next.val))
                {
                    curr.next = curr.next.next;
                    continue;
                }

                curr = curr.next;
            }

            return first;
        }

        [Test]
        public void TestCase()
        {
            var result = ModifiedList([1, 2, 3], new ListNode([1, 2, 3, 4, 5]));
            var expectedResult = new ListNode([4, 5]);
            while(result.next!=null && expectedResult.next!=null)
            {
                Assert.That( result.val , Is.EqualTo(expectedResult.val));
                result = result.next;
                expectedResult = expectedResult.next;
            }
        }

        [Test]
        public void TestCase2()
        {
            var result = ModifiedList([1], new ListNode([1, 2, 1, 2, 1, 2]));
            var expectedResult = new ListNode([2, 2, 2]);
            while (result.next != null && expectedResult.next != null)
            {
                Assert.That(result.val, Is.EqualTo(expectedResult.val));
                result = result.next;
                expectedResult = expectedResult.next;
            }
        }

        [Test]
        public void TestCase3()
        {
            var result = ModifiedList([5], new ListNode([1, 2, 3, 4]));
            var expectedResult = new ListNode([1, 2, 3, 4]);
            while (result.next != null && expectedResult.next != null)
            {
                Assert.That(result.val, Is.EqualTo(expectedResult.val));
                result = result.next;
                expectedResult = expectedResult.next;
            }
        }

    }
}
