namespace LeetCodeAlgorithms.Common
{
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;           
        }
        public ListNode(int[] intTable)
        {           
            this.val = intTable[0];
            var skipped = intTable.Skip(1).ToArray();
            if(skipped.Length > 0)
            {
                this.next = new ListNode(skipped);
            }
        }

    }
}
