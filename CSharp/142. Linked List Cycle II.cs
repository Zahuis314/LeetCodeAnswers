using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Utils;

namespace CSharp
{
    public partial class Solution
    {
        public void TestDetectCycle()
        {
            var n1_4 = new ListNode(-4);
            var n1_0 = new ListNode(0, n1_4);
            var n1_2 = new ListNode(2, n1_0);
            var n1_3 = new ListNode(3, n1_2);
            n1_4.next = n1_2;
            Console.WriteLine(DetectCycle(n1_3)==n1_2);

            var n2_2 = new ListNode(2);
            var n2_1 = new ListNode(1, n2_2);
            n2_2.next = n2_1;
            Console.WriteLine(DetectCycle(n2_1) == n2_1);

            var n3_1 = new ListNode(1);
            Console.WriteLine(DetectCycle(n3_1) == null);

            var n4_4 = new ListNode(-4);
            var n4_0 = new ListNode(0, n4_4);
            var n4_2 = new ListNode(2, n4_0);
            var n4_1 = new ListNode(3, n4_2);
            var n4_3 = new ListNode(3, n4_1);
            n4_4.next = n4_2;
            Console.WriteLine(DetectCycle(n4_3) == n4_2);

            var n5_4 = new ListNode(-4);
            var n5_5 = new ListNode(5, n5_4);
            var n5_0 = new ListNode(0, n5_5);
            var n5_2 = new ListNode(2, n5_0);
            var n5_1 = new ListNode(3, n5_2);
            var n5_3 = new ListNode(3, n5_1);
            n5_4.next = n5_2;
            Console.WriteLine(DetectCycle(n5_3) == n5_2);
        }
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head, fast = head;
            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                {
                    fast = head;
                    while(fast != slow)
                    {
                        slow = slow.next;
                        fast = fast.next;
                    }
                    return fast;
                }
            }
            return null;
        }
    }
}
