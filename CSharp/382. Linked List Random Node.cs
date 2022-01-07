using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp.Utils;

namespace CSharp
{
    public partial class Solution382
    {
        //Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen.
        //Implement the Solution class:
        //    Solution(ListNode head) Initializes the object with the integer array nums.
        //    int getRandom() Chooses a node randomly from the list and returns its value.All the nodes of the list should be equally likely to be choosen.

        //The number of nodes in the linked list will be in the range[1, 10^4].
        //-10^4 <= Node.val <= 10^4
        //At most 10^4 calls will be made to getRandom.

        //Follow up:
        //    What if the linked list is extremely large and its length is unknown to you?
        //    Could you solve this efficiently without using extra space?



        private ListNode head;

        public Solution382(ListNode head)
        {
            this.head = head;
        }

        public int GetRandom()
        {
            int reservoir=-1;
            ListNode curr = head;
            Random r = new Random();
            int n = 1;
            while (curr != null)
            {
                reservoir = r.Next(1, n + 1) == 1 ? curr.val : reservoir;
                curr = curr.next;
                n += 1;
            }
            return reservoir;
        }
    }
}
